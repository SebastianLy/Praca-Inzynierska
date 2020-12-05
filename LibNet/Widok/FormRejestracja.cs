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
            FormLogowanie form = new FormLogowanie();
            form.ShowDialog();
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
            if (hasloTextBox.Text == haslo2TextBox.Text)
            {
                Kontroler.KontrolerUzytkownik.Rejestracja(loginTextBox.Text, emailTextBox.Text, hasloTextBox.Text, imieTextBox.Text, nazwiskoTextBox.Text,
                    miejscowoscTextBox.Text, ulicaTextBox.Text, nrDomuTextBox.Text, nrMieszkaniaTextBox.Text, kodPocztowyTextBox.Text);
                FormLogowanie form = new FormLogowanie();
                form.ShowDialog();
                Close();
            }
        }
    }
}
