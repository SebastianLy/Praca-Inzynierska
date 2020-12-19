using System;
using System.Data;
using System.Windows.Forms;
using Kontroler;

namespace Widok
{
    public partial class FormUzytkownicy : Form
    {
        DataTable tabela = new DataTable("Użytkownicy");

        public FormUzytkownicy()
        {
            InitializeComponent();
        }

        private void FormUzytkownicy_Load(object sender, EventArgs e)
        {
            tabela.Columns.Add("ID", typeof(int));
            tabela.Columns.Add("Email", typeof(string));
            tabela.Columns.Add("Imię i nazwisko", typeof(string));
            tabela.Columns.Add("Rola", typeof(string));
            tabela.Columns.Add("Blokada", typeof(string));
            tabela.Columns.Add("Powód blokady", typeof(string));
            tabela.Columns.Add("Adres", typeof(string));
            KontrolerUzytkownik.WypelnijTabeleUzytkownikow(tabela);
            tabelaUzytkownicy.DataSource = tabela;
            tabelaUzytkownicy.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tabelaUzytkownicy.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tabelaUzytkownicy.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tabelaUzytkownicy.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tabelaUzytkownicy.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tabelaUzytkownicy.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tabelaUzytkownicy.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            KontrolerUzytkownik.WyszukajUzytkownikow(tabela, szukajComboBox.Text, szukajTextBox.Text);
        }

        private void btnBlokada_Click(object sender, EventArgs e)
        {
            int wiersz = tabelaUzytkownicy.SelectedCells[0].RowIndex;
            int id = (int)tabelaUzytkownicy.Rows[wiersz].Cells[0].Value;
            KontrolerUzytkownik.Blokada(id, powodTextBox.Text);
            KontrolerUzytkownik.WypelnijTabeleUzytkownikow(tabela);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int wiersz = tabelaUzytkownicy.SelectedCells[0].RowIndex;
            int id = (int)tabelaUzytkownicy.Rows[wiersz].Cells[0].Value;
            KontrolerUzytkownik.Usun(id);
            KontrolerUzytkownik.WypelnijTabeleUzytkownikow(tabela);
        }

        private void tabelaUzytkownicy_SelectionChanged(object sender, EventArgs e)
        {
            if (tabelaUzytkownicy.SelectedCells.Count == 0)
            {
                btnBlokada.Enabled = false;
                btnUsun.Enabled = false;
                btnAwans.Enabled = false;
            }
            else
            {
                btnBlokada.Enabled = true;
                btnUsun.Enabled = true;
                btnAwans.Enabled = true;
            }
        }

        private void tabelaUzytkownicy_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tabelaUzytkownicy.ClearSelection();
            btnBlokada.Enabled = false;
            btnUsun.Enabled = false;
            btnAwans.Enabled = false;
        }

        private void btnAwans_Click(object sender, EventArgs e)
        {
            int wiersz = tabelaUzytkownicy.SelectedCells[0].RowIndex;
            int id = (int)tabelaUzytkownicy.Rows[wiersz].Cells[0].Value;
            KontrolerUzytkownik.Awans(id);
            KontrolerUzytkownik.WypelnijTabeleUzytkownikow(tabela);
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            string[] ustawienia = KontrolerKsiazka.WyswietlUstawienia();
            KontrolerWypozyczenie.AutomatycznaBlokada(Convert.ToInt32(ustawienia[11]));
            KontrolerUzytkownik.WypelnijTabeleUzytkownikow(tabela);
        }
    }
}
