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
    public partial class FormLogowanie : Form
    {
        public FormLogowanie()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

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

        private void btnLogowanie_Click(object sender, EventArgs e)
        {
            bool logowanie = KontrolerUzytkownik.Logowanie(loginTextBox.Text, hasloTextBox.Text);
            if (logowanie)
            {
                labelBladLogowania.Visible = false;
                formMenuGlowne formMenu = new formMenuGlowne(loginTextBox.Text);
                formMenu.FormClosed += new FormClosedEventHandler(FormMenu_FormClosed);
                formMenu.Show();
                Hide();
            }
            else
                labelBladLogowania.Visible = true;
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void FormRejestracja_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void btnRejestracja_Click(object sender, EventArgs e)
        {
            FormRejestracja formRejestracja = new FormRejestracja();
            formRejestracja.FormClosed += new FormClosedEventHandler(FormRejestracja_FormClosed);
            formRejestracja.Show();
            Hide();
        }
    }
}
