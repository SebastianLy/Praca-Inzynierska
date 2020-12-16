using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Kontroler;

namespace Widok
{
    public partial class FormEdytujBiblioteka : Form
    {
        public FormEdytujBiblioteka()
        {
            InitializeComponent();
        }

        public FormEdytujBiblioteka(string nazwa, string adres, string telefon, string email, string p, string w, string s, string c, string p2, string s2, string n, 
            string wypozyczenia, string limit, string oplata)
        {
            InitializeComponent();
            nazwaTextBox.Text = nazwa;
            adresTextBox.Text = adres;
            telefonTextBox.Text = telefon;
            emailTextBox.Text = email;
            poniedzialekTextBox.Text = p;
            wtorekTextBox.Text = w;
            srodaTextBox.Text = s;
            czwartekTextBox.Text = c;
            piatekTextBox.Text = p2;
            sobotaTextBox.Text = s2;
            niedzielaTextBox.Text = n;
            wypozyczeniaTextBox.Text = wypozyczenia;
            limitTextBox.Text = limit;
            oplataTextBox.Text = oplata;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            KontrolerKsiazka.AktualizujUstawieniaBiblioteki(nazwaTextBox.Text, adresTextBox.Text, telefonTextBox.Text, emailTextBox.Text, poniedzialekTextBox.Text,
                wtorekTextBox.Text, srodaTextBox.Text, czwartekTextBox.Text, piatekTextBox.Text, sobotaTextBox.Text, niedzielaTextBox.Text, 
                Convert.ToInt32(wypozyczeniaTextBox.Text), Convert.ToInt32(limitTextBox.Text), Convert.ToDecimal(oplataTextBox.Text));
            Close();
        }

        private void btnMinimalizuj_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaksymalizuj_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelTytul_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
