using System;
using System.Data;
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
                if (IDUzytkownik == 0)
                {
                    FormDodajKsiazke form = new FormDodajKsiazke(
                        tabelaKsiazki.Rows[e.RowIndex].Cells[0].Value.ToString(),
                        tabelaKsiazki.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        tabelaKsiazki.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        tabelaKsiazki.Rows[e.RowIndex].Cells[3].Value.ToString(),
                        tabelaKsiazki.Rows[e.RowIndex].Cells[4].Value.ToString(),
                        tabelaKsiazki.Rows[e.RowIndex].Cells[5].Value.ToString());
                    form.ShowDialog();
                    KontrolerKsiazka.WypelnijTabeleKsiazek(tabela);
                }
            }
            catch (NullReferenceException) { }
            catch (InvalidCastException) { }

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
            if (IDUzytkownik != 0)
            {
                if (!KontrolerUzytkownik.CzyZablokowane(IDUzytkownik))
                {
                    labelBlokada.Visible = false;
                    KontrolerKsiazka.RezerwacjaKsiazki(sygnatura, IDUzytkownik);
                    KontrolerKsiazka.WypelnijTabeleKsiazek(tabela);
                }
                else
                    labelBlokada.Visible = true;
            }
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
                if (tabelaKsiazki.Rows[wiersz].Cells[6].Value.ToString() == "" && tabelaKsiazki.Rows[wiersz].Cells[7].Value.ToString() == "")
                {
                    btnRezerwacja.Enabled = true;
                }
                else
                    btnRezerwacja.Enabled = false;
            }
        }
    }
}
