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
    public partial class FormDodajKsiazke : Form
    {
        public FormDodajKsiazke()
        {
            InitializeComponent();
            btnEdytuj.Enabled = false;
            btnUsun.Enabled = false;
        }

        public FormDodajKsiazke(string sygnatura, string tytul, string autor, string gatunek, string wydanie, string wartosc)
        {
            InitializeComponent();
            string dataWydania = wydanie.Substring(wydanie.Length - 4);
            string miejsceWydania = wydanie.Substring(wydanie.IndexOf(",") + 1, wydanie.LastIndexOf(",") - wydanie.IndexOf(",") - 1);
            string wydawca = wydanie.Substring(0, wydanie.IndexOf(",") - 1);
            sygnaturaTextBox.Text = sygnatura;
            sygnaturaTextBox.Enabled = false;
            tytulTextBox.Text = tytul;
            autorTextBox.Text = autor;
            gatunekTextBox.Text = gatunek;
            wydawcaTextBox.Text = wydawca;
            miejsceWydaniaTextBox.Text = miejsceWydania;
            dataWydaniaTextBox.Text = dataWydania;
            wartoscTextBox.Text = wartosc;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KontrolerKsiazka.DodajKsiazke(sygnaturaTextBox.Text, tytulTextBox.Text, autorTextBox.Text, gatunekTextBox.Text, wydawcaTextBox.Text, 
                miejsceWydaniaTextBox.Text, dataWydaniaTextBox.Text, Convert.ToDecimal(wartoscTextBox.Text));
            Close();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            KontrolerKsiazka.UsunKsiazke(sygnaturaTextBox.Text);
            Close();
        }
    }
}
