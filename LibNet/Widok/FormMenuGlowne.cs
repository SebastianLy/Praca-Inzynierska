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

namespace Widok
{
    public partial class interfejsAdministratora : Form
    {

        // Pola
        private Button aktywnyPrzycisk;
        private Form aktywnyForm;
        
        // Konstruktor
        public interfejsAdministratora()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Metody
        private void AktywujPrzycisk(object przycisk)
        {
            if (przycisk != null)
            {
                if (aktywnyPrzycisk != (Button)przycisk)
                {
                    DezaktywujPrzyciski();
                    aktywnyPrzycisk = (Button)przycisk;
                    aktywnyPrzycisk.BackColor = Color.FromArgb(0, 89, 255);
                }
            }
        }

        private void DezaktywujPrzyciski()
        {
            foreach (Control przycisk in panelMenu.Controls)
            {
                przycisk.BackColor = Color.FromArgb(8, 17, 220);
            }
        }

        private void OtworzForm(Form form, object btnSender)
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
            lblTytul.Text = form.Text;
        }

        private void btnBiblioteka_Click(object sender, EventArgs e)
        {
            AktywujPrzycisk(sender);
        }

        private void btnUzytkownicy_Click(object sender, EventArgs e)
        {
            AktywujPrzycisk(sender);
        }

        private void btnKsiazki_Click(object sender, EventArgs e)
        {
            AktywujPrzycisk(sender);
        }

        private void btnWypozyczalnia_Click(object sender, EventArgs e)
        {
            AktywujPrzycisk(sender);
        }

        private void btnPlatnosci_Click(object sender, EventArgs e)
        {
            AktywujPrzycisk(sender);
        }

        private void panelTytul_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
            //SendMessage(Handle, 0xA1, 0x2, 0);
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
    }
}
