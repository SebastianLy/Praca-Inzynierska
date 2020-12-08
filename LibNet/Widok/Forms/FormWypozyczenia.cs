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
        public FormWypozyczenia()
        {
            InitializeComponent();
        }

        private void tabelaWypozyczenia_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tabelaWypozyczenia.ClearSelection();
        }

        private void FormWypozyczenia_Load(object sender, EventArgs e)
        {
            tabela.Columns.Add("ID Wypożyczenia", typeof(int));
            tabela.Columns.Add("Data Wypożyczenia", typeof(DateTime));
            tabela.Columns.Add("Data Zwrotu", typeof(DateTime));
            tabela.Columns.Add("Osoba Wypożyczająca", typeof(int));
            tabela.Columns.Add("Sygnatura", typeof(string));
            // Część wspólna sygnatura-wypozyczenia, i czesc wspólna wypozyczenia-uzytkownicy
            KontrolerWypozyczenie.WyswietlWypozyczenia(tabela);
            tabelaWypozyczenia.DataSource = tabela;
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {

        }

        private void btnWypozycz_Click(object sender, EventArgs e)
        {
            List<string> sygnatury = new List<string>();
            string s = sygnaturyTextBox.Text;
            for (int i = 0; i < sygnaturyTextBox.Text.Count(f => f ==',') + 1; i++)
            {
                if (s.Count(f => f == ',') == 0)
                    sygnatury.Add(s);
                else
                {
                    sygnatury.Add(s.Substring(0, s.IndexOf(',')));
                    s.Remove(0, s.IndexOf(','));
                }
            }
            KontrolerWypozyczenie.Wypozycz(sygnatury, Convert.ToInt32(wypozyczajacyTextBox.Text));
            KontrolerWypozyczenie.WyswietlWypozyczenia(tabela);
        }

        private void btnZwroc_Click(object sender, EventArgs e)
        {
            int id = (int)tabelaWypozyczenia.SelectedRows[0].Cells[0].Value;
            KontrolerWypozyczenie.Zwroc(id);
            KontrolerWypozyczenie.WyswietlWypozyczenia(tabela);
        }

        private void tabelaWypozyczenia_SelectionChanged(object sender, EventArgs e)
        {
            if (tabelaWypozyczenia.SelectedCells.Count == 0)
                btnZwroc.Enabled = false;
            else
                btnZwroc.Enabled = true;
        }
    }
}
