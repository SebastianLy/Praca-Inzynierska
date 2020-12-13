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
    public partial class FormKsiazki : Form
    {
        DataTable tabela = new DataTable("Książki");
        private readonly int IDUzytkownik;
        public FormKsiazki()
        {
            InitializeComponent();
        }

        public FormKsiazki(int idUzytkownika)
        {
            InitializeComponent();
            IDUzytkownik = idUzytkownika;
            if (IDUzytkownik != 0)
                btnDodaj.Visible = false;
            if (idUzytkownika == 0)
                btnRezerwacja.Visible = false;
        }

        private void FormKsiazki_Load(object sender, EventArgs e)
        {
            tabela.Columns.Add("Sygnatura", typeof(string));
            tabela.Columns.Add("Tytuł", typeof(string));
            tabela.Columns.Add("Autor", typeof(string));
            tabela.Columns.Add("Gatunek", typeof(string));
            tabela.Columns.Add("Wydanie", typeof(string));
            tabela.Columns.Add("Wartość", typeof(decimal));
            tabela.Columns.Add("Rezerwacja", typeof(DateTime));
            tabela.Columns.Add("Przetrzymujący", typeof(int));
            KontrolerKsiazka.WypelnijTabeleKsiazek(tabela);
            tabelaKsiazki.DataSource = tabela;
            tabelaKsiazki.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tabelaKsiazki.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tabelaKsiazki.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tabelaKsiazki.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tabelaKsiazki.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tabelaKsiazki.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tabelaKsiazki.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tabelaKsiazki.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormDodajKsiazke form = new FormDodajKsiazke();
            form.ShowDialog();
            KontrolerKsiazka.WypelnijTabeleKsiazek(tabela);
        }

        private void tabelaKsiazki_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormDodajKsiazke form = new FormDodajKsiazke(
                    tabelaKsiazki.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    tabelaKsiazki.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    tabelaKsiazki.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    tabelaKsiazki.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    tabelaKsiazki.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    tabelaKsiazki.Rows[e.RowIndex].Cells[5].Value.ToString());
                form.ShowDialog();
            }
            catch (NullReferenceException) { }
            catch (InvalidCastException) { }
            KontrolerKsiazka.WypelnijTabeleKsiazek(tabela);
        }

        private void tabelaKsiazki_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tabelaKsiazki.ClearSelection();
            btnRezerwacja.Enabled = false;
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            KontrolerKsiazka.WyszukajKsiazke(tabela, szukajComboBox.Text, szukajTextBox.Text);
        }

        private void btnRezerwacja_Click(object sender, EventArgs e)
        {
            int wiersz = tabelaKsiazki.SelectedCells[0].RowIndex;
            string sygnatura = tabelaKsiazki.Rows[wiersz].Cells[0].Value.ToString();
            KontrolerKsiazka.RezerwacjaKsiazki(sygnatura, IDUzytkownik);
            KontrolerKsiazka.WypelnijTabeleKsiazek(tabela);
        }

        private void tabelaKsiazki_SelectionChanged(object sender, EventArgs e)
        {
            if (tabelaKsiazki.SelectedCells.Count == 0)
            {
                btnRezerwacja.Enabled = false;
            }
            else
            {
                int wiersz = tabelaKsiazki.SelectedCells[0].RowIndex;
                if (tabelaKsiazki.Rows[wiersz].Cells[6].Value == null && tabelaKsiazki.Rows[wiersz].Cells[7].Value == null)
                {
                    btnRezerwacja.Enabled = true;
                }
                else
                    btnRezerwacja.Enabled = false;
            }
        }
    }
}
