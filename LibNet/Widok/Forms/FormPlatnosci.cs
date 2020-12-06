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
        public FormPlatnosci()
        {
            InitializeComponent();
        }

        private void btnDodajPlatnosc_Click(object sender, EventArgs e)
        {
            KontrolerUzytkownik.DodajPlatnosc(Convert.ToInt32(uzytkownikTextBox.Text), opisTextBox.Text, Convert.ToDecimal(kwotaTextBox.Text));
            KontrolerUzytkownik.WyswietlPlatnosci(tabela);
        }

        private void FormPlatnosci_Load(object sender, EventArgs e)
        {
            tabela.Columns.Add("ID Płatności", typeof(int));
            tabela.Columns.Add("ID Płacącego", typeof(int));
            tabela.Columns.Add("Płacący", typeof(string));
            tabela.Columns.Add("Data zapłaty", typeof(DateTime));
            tabela.Columns.Add("Kwota", typeof(decimal));
            tabela.Columns.Add("Opis zapłaty", typeof(string));
            KontrolerUzytkownik.WyswietlPlatnosci(tabela);
            tabelaPlatnosci.DataSource = tabela;
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {

        }
    }
}
