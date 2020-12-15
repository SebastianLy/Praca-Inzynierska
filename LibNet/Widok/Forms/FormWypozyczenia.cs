using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kontroler;

namespace Widok
{
    public partial class FormWypozyczenia : Form
    {
        DataTable tabela = new DataTable("Wypożyczenia");
        private readonly int IDUzytkownik;
        public FormWypozyczenia()
        {
            InitializeComponent();
        }

        public FormWypozyczenia(int idUzytkownika)
        {
            InitializeComponent();
            IDUzytkownik = idUzytkownika;
            if (IDUzytkownik != 0)
            {
                panelPrzyciski.Visible = false;
            }
        }

        private void tabelaWypozyczenia_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tabelaWypozyczenia.ClearSelection();
        }

        private void FormWypozyczenia_Load(object sender, EventArgs e)
        {
            if (IDUzytkownik == 0)
            {
                tabela.Columns.Add("ID Wypożyczenia", typeof(int));
                tabela.Columns.Add("Data Wypożyczenia", typeof(DateTime));
                tabela.Columns.Add("Data Zwrotu", typeof(DateTime));
                tabela.Columns.Add("Wypożyczający", typeof(int));
                tabela.Columns.Add("Sygnatura", typeof(string));
                tabela.Columns.Add("Tytuł", typeof(string));
                KontrolerWypozyczenie.WyswietlWypozyczenia(tabela, IDUzytkownik);
                tabelaWypozyczenia.DataSource = tabela;
                tabelaWypozyczenia.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaWypozyczenia.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaWypozyczenia.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaWypozyczenia.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaWypozyczenia.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaWypozyczenia.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                tabela.Columns.Add("ID Wypożyczenia", typeof(int));
                tabela.Columns.Add("Data Wypożyczenia", typeof(DateTime));
                tabela.Columns.Add("Data Zwrotu", typeof(DateTime));
                tabela.Columns.Add("Sygnatura", typeof(string));
                tabela.Columns.Add("Tytuł", typeof(string));
                KontrolerWypozyczenie.WyswietlWypozyczenia(tabela, IDUzytkownik);
                tabelaWypozyczenia.DataSource = tabela;
                tabelaWypozyczenia.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaWypozyczenia.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaWypozyczenia.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaWypozyczenia.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaWypozyczenia.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            KontrolerWypozyczenie.WyszukajWypozyczenia(tabela, szukajComboBox.Text, szukajTextBox.Text, IDUzytkownik);
        }

        private void btnWypozycz_Click(object sender, EventArgs e)
        {
            try
            {
                bool wypozycz = true;
                List<string> sygnatury;
                string s = sygnaturyTextBox.Text;
                string[] s1 = s.Split(',');
                sygnatury = s1.ToList();
                if (KontrolerUzytkownik.CzyIstnieje(Convert.ToInt32(wypozyczajacyTextBox.Text)))
                    labelBladUzytkownik.Visible = false;
                else
                {
                    wypozycz = false;
                    labelBladUzytkownik.Visible = true;
                }
                if (KontrolerKsiazka.CzyIstnieje(sygnatury))
                    labelBladKsiazka.Visible = false;
                else
                {
                    wypozycz = false;
                    labelBladKsiazka.Visible = true;
                }
                if (IDUzytkownik != 0)
                {
                    if (!KontrolerUzytkownik.CzyZablokowane(IDUzytkownik))
                        labelBlokada.Visible = false;
                    else
                    {
                        wypozycz = false;
                        labelBlokada.Visible = true;
                    }
                }
                if (KontrolerKsiazka.CzyZajete(sygnatury))
                    labelZajete.Visible = false;
                else
                {
                    wypozycz = false;
                    labelZajete.Visible = true;
                }
                if (wypozycz)
                {
                    KontrolerWypozyczenie.Wypozycz(sygnatury, Convert.ToInt32(wypozyczajacyTextBox.Text));
                    KontrolerWypozyczenie.WyswietlWypozyczenia(tabela, IDUzytkownik);
                }
            }
            catch (FormatException) { }
        }

        private void btnZwroc_Click(object sender, EventArgs e)
        {
            int wiersz = tabelaWypozyczenia.SelectedCells[0].RowIndex;
            string ids = tabelaWypozyczenia.Rows[wiersz].Cells[4].Value.ToString();
            int idw = (int)tabelaWypozyczenia.Rows[wiersz].Cells[0].Value;
            KontrolerWypozyczenie.Zwroc(ids, idw);
            KontrolerWypozyczenie.WyswietlWypozyczenia(tabela, IDUzytkownik);
        }

        private void tabelaWypozyczenia_SelectionChanged(object sender, EventArgs e)
        {
            if (tabelaWypozyczenia.SelectedCells.Count != 0)
            {
                if (tabelaWypozyczenia.Rows[tabelaWypozyczenia.SelectedCells[0].RowIndex].Cells[2].Value.ToString() == "")
                    btnZwroc.Enabled = true;
                else
                    btnZwroc.Enabled = false;
            }
            else
                btnZwroc.Enabled = false;
        }
    }
}
