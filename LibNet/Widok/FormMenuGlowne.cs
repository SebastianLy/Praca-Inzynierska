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
    public partial class formMenuGlowne : Form
    {

        // Pola
        private Button aktywnyPrzycisk;
        private Form aktywnyForm;
        
        // Konstruktor
        public formMenuGlowne()
        {
            InitializeComponent();
            timer1.Start();
            foreach (Button button in panelMenu.Controls.OfType<Button>())
            {
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(59, 78, 255);
            }
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
                    aktywnyPrzycisk.TextAlign = ContentAlignment.MiddleRight;
                    aktywnyPrzycisk.ImageAlign = ContentAlignment.MiddleRight;
                    aktywnyPrzycisk.TextImageRelation = TextImageRelation.TextBeforeImage;
                    lblTytul.Text = aktywnyPrzycisk.Text.Remove(0, 5);
                }
            }
        }

        private void DezaktywujPrzyciski()
        {
            if (aktywnyPrzycisk != null)
            {
                foreach (Control przycisk in panelMenu.Controls)
                {
                    przycisk.BackColor = Color.FromArgb(8, 17, 220);
                    aktywnyPrzycisk.TextAlign = ContentAlignment.MiddleLeft;
                    aktywnyPrzycisk.ImageAlign = ContentAlignment.MiddleLeft;
                    aktywnyPrzycisk.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = PointToClient(pos);
                if (pos.Y < 32)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= ClientSize.Width - 16 && pos.Y >= ClientSize.Height - 16)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
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
            OtworzForm(new FormUzytkownicy(), sender);
        }

        private void btnKsiazki_Click(object sender, EventArgs e)
        {
            OtworzForm(new FormKsiazki(), sender);
        }

        private void btnWypozyczalnia_Click(object sender, EventArgs e)
        {
            AktywujPrzycisk(sender);
        }

        private void btnPlatnosci_Click(object sender, EventArgs e)
        {
            OtworzForm(new FormPlatnosci(), sender);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelZegar.Text = Convert.ToString(DateTime.Now);
        }

        private void lblNazwa_Click(object sender, EventArgs e)
        {
            if (aktywnyForm != null)
                aktywnyForm.Close();
        }
    }
}
