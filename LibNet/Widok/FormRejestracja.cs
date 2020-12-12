﻿using System;
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

namespace Widok
{
    public partial class FormRejestracja : Form
    {
        public FormRejestracja()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

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

        private void btnRejestracja_Click(object sender, EventArgs e)
        {
            bool rejestracja = true;
            if (imieTextBox.Text.Length < 1)
            {
                rejestracja = false;
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.ForeColor = Color.Gainsboro;
                rejestracja = true;
            }
            if (nazwiskoTextBox.Text.Length < 1)
            {
                rejestracja = false;
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.ForeColor = Color.Gainsboro;
                rejestracja = true;
            }
            if (loginTextBox.Text.Length < 1 || loginTextBox.Text.Any(c => c > 255) || !Kontroler.KontrolerUzytkownik.LoginUnikatowy(loginTextBox.Text))
            {
                rejestracja = false;
                label3.ForeColor = Color.Red;
            }
            else
            {
                label3.ForeColor = Color.Gainsboro;
                rejestracja = true;
            }
            if (emailTextBox.Text.Length < 1 || emailTextBox.Text.Any(c => c > 255) || !Kontroler.KontrolerUzytkownik.EmailUnikatowy(emailTextBox.Text))
            {
                rejestracja = false;
                label4.ForeColor = Color.Red;
            }
            else
            {
                label4.ForeColor = Color.Gainsboro;
                rejestracja = true;
            }
            if (hasloTextBox.Text.Length < 8)
            {
                rejestracja = false;
                label5.ForeColor = Color.Red;
            }
            else
            {
                label5.ForeColor = Color.Gainsboro;
                rejestracja = true;
            }
            if (hasloTextBox.Text != haslo2TextBox.Text)
            {
                rejestracja = false;
                label6.ForeColor = Color.Red;
            }
            else
            {
                label6.ForeColor = Color.Gainsboro;
                rejestracja = true;
            }
            if (miejscowoscTextBox.Text.Length < 1)
            {
                rejestracja = false;
                label7.ForeColor = Color.Red;
            }
            else
            {
                label7.ForeColor = Color.Gainsboro;
                rejestracja = true;
            }
            if (nrDomuTextBox.Text.Length < 1)
            {
                rejestracja = false;
                label9.ForeColor = Color.Red;
            }
            else
            {
                label9.ForeColor = Color.Gainsboro;
                rejestracja = true;
            }
            if (!nrMieszkaniaTextBox.Text.All(char.IsDigit))
            {
                rejestracja = false;
                label10.ForeColor = Color.Red;
            }
            else
            {
                label10.ForeColor = Color.Gainsboro;
                rejestracja = true;
            }
            if (!new Regex("[0-9]{2}-[0-9]{3}").IsMatch(kodPocztowyTextBox.Text))
            {
                rejestracja = false;
                label11.ForeColor = Color.Red;
            }
            else
            {
                label11.ForeColor = Color.Gainsboro;
                rejestracja = true;
            }
            if (rejestracja)
            {
                Kontroler.KontrolerUzytkownik.Rejestracja(loginTextBox.Text, emailTextBox.Text, hasloTextBox.Text, imieTextBox.Text, nazwiskoTextBox.Text,
                    miejscowoscTextBox.Text, ulicaTextBox.Text, nrDomuTextBox.Text, nrMieszkaniaTextBox.Text, kodPocztowyTextBox.Text.Replace("-",""));
                Close();
            }
        }

        private void panelTytul_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
