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
    public partial class FormEdytujBiblioteka : Form
    {
        public FormEdytujBiblioteka()
        {
            InitializeComponent();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            KontrolerKsiazka.AktualizujUstawieniaBiblioteki(nazwaTextBox.Text, adresTextBox.Text, telefonTextBox.Text, emailTextBox.Text, poniedzialekTextBox.Text,
                wtorekTextBox.Text, srodaTextBox.Text, czwartekTextBox.Text, piatekTextBox.Text, sobotaTextBox.Text, niedzielaTextBox.Text, 
                Convert.ToInt32(wypozyczeniaTextBox.Text), Convert.ToInt32(limitTextBox.Text), Convert.ToDecimal(oplataTextBox.Text));
            Close();
        }
    }
}
