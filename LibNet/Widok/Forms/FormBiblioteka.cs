using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Widok
{
    public partial class FormBiblioteka : Form
    {
        private readonly int IDUzytkownik;
        public FormBiblioteka()
        {
            InitializeComponent();
        }

        public FormBiblioteka(int idUzytkownika)
        {
            InitializeComponent();
            IDUzytkownik = idUzytkownika;
            if (IDUzytkownik != 0)
            {
                btnEdytuj.Visible = false;
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            FormEdytujBiblioteka formEdytuj = new FormEdytujBiblioteka(labelNazwa.Text, labelAdres.Text, labelTelefon.Text, labelEmail.Text, labelPoniedzialek.Text, 
                labelWtorek.Text, labelSroda.Text, labelCzwartek.Text, labelPiatek.Text, labelSobota.Text, labelNiedziela.Text, labelWypozyczenie.Text, 
                labelLimit.Text, labelOplata.Text);
            formEdytuj.ShowDialog();
            string[] ustawienia = Kontroler.KontrolerKsiazka.WyswietlUstawienia();
            labelNazwa.Text = ustawienia[0];
            labelAdres.Text = ustawienia[1];
            labelTelefon.Text = ustawienia[2];
            labelEmail.Text = ustawienia[3];
            labelPoniedzialek.Text = ustawienia[4];
            labelWtorek.Text = ustawienia[5];
            labelSroda.Text = ustawienia[6];
            labelCzwartek.Text = ustawienia[7];
            labelPiatek.Text = ustawienia[8];
            labelSobota.Text = ustawienia[9];
            labelNiedziela.Text = ustawienia[10];
            labelWypozyczenie.Text = ustawienia[11];
            labelLimit.Text = ustawienia[12];
            labelOplata.Text = ustawienia[13];
        }

        private void FormBiblioteka_Load(object sender, EventArgs e)
        {
            string[] ustawienia = Kontroler.KontrolerKsiazka.WyswietlUstawienia();
            labelNazwa.Text = ustawienia[0];
            labelAdres.Text = ustawienia[1];
            labelTelefon.Text = ustawienia[2];
            labelEmail.Text = ustawienia[3];
            labelPoniedzialek.Text = ustawienia[4];
            labelWtorek.Text = ustawienia[5];
            labelSroda.Text = ustawienia[6];
            labelCzwartek.Text = ustawienia[7];
            labelPiatek.Text = ustawienia[8];
            labelSobota.Text = ustawienia[9];
            labelNiedziela.Text = ustawienia[10];
            labelWypozyczenie.Text = ustawienia[11];
            labelLimit.Text = ustawienia[12];
            labelOplata.Text = ustawienia[13];
        }
    }
}
