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
            tabelaUzytkownicy.Columns[0].Width = 60;
            tabelaUzytkownicy.Columns[1].Width = 150;
            tabelaUzytkownicy.Columns[2].Width = 150;
            tabelaUzytkownicy.Columns[3].Width = 50;
            tabelaUzytkownicy.Columns[4].Width = 50;
            tabelaUzytkownicy.Columns[5].Width = 150;
            tabelaUzytkownicy.Columns[6].Width = 150;
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            KontrolerUzytkownik.Wyszukaj(tabela, szukajTextBox.Text, szukajComboBox.Text);
        }

        private void btnBlokada_Click(object sender, EventArgs e)
        {
            int id = (int)tabelaUzytkownicy.SelectedRows[0].Cells[0].Value;
            KontrolerUzytkownik.Blokada(id, powodTextBox.Text);
            KontrolerUzytkownik.WypelnijTabeleUzytkownikow(tabela);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int id = (int)tabelaUzytkownicy.SelectedRows[0].Cells[0].Value;
            KontrolerUzytkownik.Usun(id);
            KontrolerUzytkownik.WypelnijTabeleUzytkownikow(tabela);
        }

        private void tabelaUzytkownicy_SelectionChanged(object sender, EventArgs e)
        {
            if (tabelaUzytkownicy.SelectedRows != null)
            {
                btnBlokada.Enabled = true;
                btnUsun.Enabled = true;
            }
            else
            {
                btnBlokada.Enabled = false;
                btnUsun.Enabled = false;
            }
        }
    }
}
