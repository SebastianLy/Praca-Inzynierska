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
    public partial class FormPlatnosci : Form
    {
        DataTable tabela = new DataTable("Płatności");
        private readonly int IDUzytkownik;
        public FormPlatnosci()
        {
            InitializeComponent();
        }

        public FormPlatnosci(int idUzytkownika)
        {
            InitializeComponent();
            IDUzytkownik = idUzytkownika;
            if (IDUzytkownik != 0)
            {
                panelPrzyciski.Visible = false;
            }
        }

        private void btnDodajPlatnosc_Click(object sender, EventArgs e)
        {
            try
            {
                if (KontrolerUzytkownik.CzyIstnieje(Convert.ToInt32(uzytkownikTextBox.Text)))
                {
                    KontrolerUzytkownik.DodajPlatnosc(Convert.ToInt32(uzytkownikTextBox.Text), opisTextBox.Text, Convert.ToDecimal(kwotaTextBox.Text));
                    KontrolerUzytkownik.WyswietlPlatnosci(tabela, IDUzytkownik);
                    labelBlad.Visible = false;
                }
                else
                    labelBlad.Visible = true;
            }
            catch (FormatException) { }
        }

        private void FormPlatnosci_Load(object sender, EventArgs e)
        {
            if (IDUzytkownik == 0)
            {
                tabela.Columns.Add("ID Płatności", typeof(int));
                tabela.Columns.Add("ID Płacącego", typeof(int));
                tabela.Columns.Add("Płacący", typeof(string));
                tabela.Columns.Add("Data zapłaty", typeof(DateTime));
                tabela.Columns.Add("Kwota", typeof(decimal));
                tabela.Columns.Add("Opis zapłaty", typeof(string));
                KontrolerUzytkownik.WyswietlPlatnosci(tabela, IDUzytkownik);
                tabelaPlatnosci.DataSource = tabela;
                tabelaPlatnosci.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaPlatnosci.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaPlatnosci.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaPlatnosci.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaPlatnosci.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaPlatnosci.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                tabela.Columns.Add("ID Płatności", typeof(int));
                tabela.Columns.Add("Płacący", typeof(string));
                tabela.Columns.Add("Data zapłaty", typeof(DateTime));
                tabela.Columns.Add("Kwota", typeof(decimal));
                tabela.Columns.Add("Opis zapłaty", typeof(string));
                KontrolerUzytkownik.WyswietlPlatnosci(tabela, IDUzytkownik);
                tabelaPlatnosci.DataSource = tabela;
                tabelaPlatnosci.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaPlatnosci.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaPlatnosci.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaPlatnosci.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tabelaPlatnosci.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            KontrolerUzytkownik.WyszukajPlatnosci(tabela, szukajComboBox.Text, szukajTextBox.Text, IDUzytkownik);
        }

        private void tabelaPlatnosci_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tabelaPlatnosci.ClearSelection();
        }
    }
}
