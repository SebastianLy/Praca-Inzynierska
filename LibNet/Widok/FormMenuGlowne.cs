using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Kontroler;
using System.Globalization;

namespace Widok
{
    public partial class formMenuGlowne : Form
    {
        private Button aktywnyPrzycisk;
        private Form aktywnyForm;
        private readonly int IDUzytkownik;

        public formMenuGlowne()
        {
            InitializeComponent();
            timer1.Start();
        }

        public formMenuGlowne(string login)
        {
            InitializeComponent();
            timer1.Start();
            labelUzytkownik.Text = KontrolerUzytkownik.ZnajdzImie(login);
            IDUzytkownik = KontrolerUzytkownik.IDRola(login);
            if (IDUzytkownik != 0)
            {
                if (KontrolerUzytkownik.CzyZablokowane(IDUzytkownik))
                {
                    labelBlokada.Visible = true;
                    labelBlokadaPowod.Visible = true;
                    labelBlokadaPowod.Text = KontrolerUzytkownik.PowodBlokady(IDUzytkownik);
                }
            }
            if (IDUzytkownik != 0)
                btnUzytkownicy.Visible = false;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void AktywujPrzycisk(object przycisk)
        {
            if (przycisk != null)
            {
                if (aktywnyPrzycisk != (Button)przycisk)
                {

                    DezaktywujPrzyciski();
                    aktywnyPrzycisk = (Button)przycisk;
                    aktywnyPrzycisk.Text.Trim();
                    lblTytul.Text = aktywnyPrzycisk.Text;
                    aktywnyPrzycisk.Text += "    ";
                    aktywnyPrzycisk.BackColor = Color.FromArgb(70, 70, 90);
                    aktywnyPrzycisk.TextAlign = ContentAlignment.MiddleRight;
                    aktywnyPrzycisk.ImageAlign = ContentAlignment.MiddleRight;
                    aktywnyPrzycisk.TextImageRelation = TextImageRelation.TextBeforeImage;                    
                }
            }
        }

        private void DezaktywujPrzyciski()
        {
            if (aktywnyPrzycisk != null)
            {
                foreach (Control przycisk in panelMenu.Controls)
                {
                    if (przycisk != panelLogo)
                    {
                        przycisk.BackColor = Color.FromArgb(51, 51, 76);
                        aktywnyPrzycisk.Text = "    " + aktywnyPrzycisk.Text.Trim();
                        aktywnyPrzycisk.TextAlign = ContentAlignment.MiddleLeft;
                        aktywnyPrzycisk.ImageAlign = ContentAlignment.MiddleLeft;
                        aktywnyPrzycisk.TextImageRelation = TextImageRelation.ImageBeforeText;
                    }
                }
            }
        }

        private void OtworzForm(Form form, object btnSender, string tytul)
        {
            if (aktywnyForm != null)
                aktywnyForm.Close();
            AktywujPrzycisk(btnSender);
            aktywnyForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelZakladka.Controls.Add(form);
            panelZakladka.Tag = form;
            form.BringToFront();
            form.Show();
            lblTytul.Text = tytul;
        }

        private void btnBiblioteka_Click(object sender, EventArgs e)
        {
            OtworzForm(new FormBiblioteka(IDUzytkownik), sender, "Biblioteka");
        }

        private void btnUzytkownicy_Click(object sender, EventArgs e)
        {
            OtworzForm(new FormUzytkownicy(), sender, "Użytkownicy");
        }

        private void btnKsiazki_Click(object sender, EventArgs e)
        {
            OtworzForm(new FormKsiazki(IDUzytkownik), sender, "Książki");
        }

        private void btnWypozyczenia_Click(object sender, EventArgs e)
        {
            OtworzForm(new FormWypozyczenia(IDUzytkownik), sender, "Wypożyczenia");
        }

        private void btnPlatnosci_Click(object sender, EventArgs e)
        {
            OtworzForm(new FormPlatnosci(IDUzytkownik), sender, "Płatności");
        }

        private void panelTytul_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelZegar.Text = Convert.ToString(DateTime.Now.ToString("dddd", new CultureInfo("pl-PL")) + ", " + DateTime.Now.ToString("dd") + "." +
                DateTime.Now.ToString("MM") + "." + DateTime.Now.ToString("yyyy") + " " + Environment.NewLine + DateTime.Now.ToString("HH") + ":" +
                DateTime.Now.ToString("mm") + ":" + DateTime.Now.ToString("ss"));
        }

        private void lblNazwa_Click(object sender, EventArgs e)
        {
            if (aktywnyForm != null)
            {
                DezaktywujPrzyciski();
                aktywnyForm.Close();
            }
        }
    }
}
