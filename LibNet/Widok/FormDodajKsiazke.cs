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
using System.Text.RegularExpressions;
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

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public FormDodajKsiazke(string sygnatura, string tytul, string autor, string gatunek, string wydanie, string wartosc)
        {
            InitializeComponent();
            string dataWydania = wydanie.Substring(wydanie.Length - 4);
            string miejsceWydania = wydanie.Substring(wydanie.IndexOf(",") + 2, wydanie.LastIndexOf(",") - wydanie.IndexOf(",") - 2);
            string wydawca = wydanie.Substring(0, wydanie.IndexOf(","));
            sygnaturaTextBox.Text = sygnatura;
            sygnaturaTextBox.Enabled = false;
            tytulTextBox.Text = tytul;
            autorTextBox.Text = autor;
            gatunekTextBox.Text = gatunek;
            wydawcaTextBox.Text = wydawca;
            miejsceWydaniaTextBox.Text = miejsceWydania;
            dataWydaniaTextBox.Text = dataWydania;
            wartoscTextBox.Text = wartosc;
            btnDodaj.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            bool ksiazka = true;
            if (sygnaturaTextBox.TextLength < 1 || !KontrolerKsiazka.SygnaturaUnikatowa(sygnaturaTextBox.Text) || sygnaturaTextBox.Text.Any(c => c > 255))
            {
                label1.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label1.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (tytulTextBox.TextLength < 1)
            {
                label2.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label2.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (autorTextBox.TextLength < 1)
            {
                label3.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label3.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (gatunekTextBox.TextLength < 1 || gatunekTextBox.Text.Any(c => c > 255))
            {
                label4.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label4.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (wydawcaTextBox.TextLength < 1)
            {
                label5.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label5.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (miejsceWydaniaTextBox.TextLength < 1)
            {
                label6.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label6.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (!new Regex("[1-2][0-9]{3}").IsMatch(dataWydaniaTextBox.Text))
            {
                label7.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label7.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (wartoscTextBox.TextLength < 1)
            {
                label8.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label8.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (ksiazka)
            {
                KontrolerKsiazka.DodajKsiazke(sygnaturaTextBox.Text, tytulTextBox.Text, autorTextBox.Text, gatunekTextBox.Text, wydawcaTextBox.Text,
                    miejsceWydaniaTextBox.Text, dataWydaniaTextBox.Text, Convert.ToDecimal(wartoscTextBox.Text));
                Close();
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            bool ksiazka = true;
            if (sygnaturaTextBox.TextLength < 1 || !KontrolerKsiazka.SygnaturaUnikatowa(sygnaturaTextBox.Text))
            {
                label1.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label1.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (tytulTextBox.TextLength < 1)
            {
                label2.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label2.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (autorTextBox.TextLength < 1)
            {
                label3.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label3.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (gatunekTextBox.TextLength < 1 || gatunekTextBox.Text.Any(c => c > 255))
            {
                label4.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label4.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (wydawcaTextBox.TextLength < 1)
            {
                label5.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label5.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (miejsceWydaniaTextBox.TextLength < 1)
            {
                label6.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label6.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (!new Regex("[1-2][0-9]{3}").IsMatch(dataWydaniaTextBox.Text))
            {
                label7.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label7.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (wartoscTextBox.TextLength < 1)
            {
                label8.ForeColor = Color.Red;
                ksiazka = false;
            }
            else
            {
                label8.ForeColor = Color.Gainsboro;
                ksiazka = true;
            }
            if (ksiazka)
            {
                try
                {
                    KontrolerKsiazka.EdytujKsiazke(sygnaturaTextBox.Text, tytulTextBox.Text, autorTextBox.Text, gatunekTextBox.Text, wydawcaTextBox.Text,
                        miejsceWydaniaTextBox.Text, dataWydaniaTextBox.Text, Convert.ToDecimal(wartoscTextBox.Text));
                    Close();
                }
                catch (FormatException) { }
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            KontrolerKsiazka.UsunKsiazke(sygnaturaTextBox.Text);
            Close();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnMinimalizuj_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelTytul_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
