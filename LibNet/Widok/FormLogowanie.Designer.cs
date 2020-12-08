
namespace Widok
{
    partial class FormLogowanie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogowanie));
            this.labelTytul = new System.Windows.Forms.Label();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.panelTytul = new System.Windows.Forms.Panel();
            this.btnMinimalizuj = new System.Windows.Forms.Button();
            this.btnMaksymalizuj = new System.Windows.Forms.Button();
            this.panelLogowanie = new System.Windows.Forms.Panel();
            this.btnRejestracja = new System.Windows.Forms.Button();
            this.labelRejestracja = new System.Windows.Forms.Label();
            this.btnLogowanie = new System.Windows.Forms.Button();
            this.hasloTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.labelHaslo = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelTytul.SuspendLayout();
            this.panelLogowanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTytul
            // 
            this.labelTytul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTytul.AutoSize = true;
            this.labelTytul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTytul.Location = new System.Drawing.Point(167, 25);
            this.labelTytul.Name = "labelTytul";
            this.labelTytul.Size = new System.Drawing.Size(156, 31);
            this.labelTytul.TabIndex = 0;
            this.labelTytul.Text = "Zaloguj się";
            // 
            // btnZamknij
            // 
            this.btnZamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZamknij.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZamknij.BackgroundImage")));
            this.btnZamknij.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZamknij.FlatAppearance.BorderSize = 0;
            this.btnZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZamknij.Location = new System.Drawing.Point(447, 12);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(21, 20);
            this.btnZamknij.TabIndex = 1;
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // panelTytul
            // 
            this.panelTytul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(196)))));
            this.panelTytul.Controls.Add(this.btnMinimalizuj);
            this.panelTytul.Controls.Add(this.btnMaksymalizuj);
            this.panelTytul.Controls.Add(this.labelTytul);
            this.panelTytul.Controls.Add(this.btnZamknij);
            this.panelTytul.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTytul.Location = new System.Drawing.Point(0, 0);
            this.panelTytul.Name = "panelTytul";
            this.panelTytul.Size = new System.Drawing.Size(480, 80);
            this.panelTytul.TabIndex = 2;
            this.panelTytul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTytul_MouseDown);
            // 
            // btnMinimalizuj
            // 
            this.btnMinimalizuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimalizuj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimalizuj.BackgroundImage")));
            this.btnMinimalizuj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimalizuj.FlatAppearance.BorderSize = 0;
            this.btnMinimalizuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimalizuj.Location = new System.Drawing.Point(393, 12);
            this.btnMinimalizuj.Name = "btnMinimalizuj";
            this.btnMinimalizuj.Size = new System.Drawing.Size(21, 20);
            this.btnMinimalizuj.TabIndex = 3;
            this.btnMinimalizuj.UseVisualStyleBackColor = true;
            this.btnMinimalizuj.Click += new System.EventHandler(this.btnMinimalizuj_Click);
            // 
            // btnMaksymalizuj
            // 
            this.btnMaksymalizuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaksymalizuj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaksymalizuj.BackgroundImage")));
            this.btnMaksymalizuj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaksymalizuj.FlatAppearance.BorderSize = 0;
            this.btnMaksymalizuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaksymalizuj.Location = new System.Drawing.Point(420, 12);
            this.btnMaksymalizuj.Name = "btnMaksymalizuj";
            this.btnMaksymalizuj.Size = new System.Drawing.Size(21, 20);
            this.btnMaksymalizuj.TabIndex = 2;
            this.btnMaksymalizuj.UseVisualStyleBackColor = true;
            this.btnMaksymalizuj.Click += new System.EventHandler(this.btnMaksymalizuj_Click);
            // 
            // panelLogowanie
            // 
            this.panelLogowanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(240)))));
            this.panelLogowanie.Controls.Add(this.btnRejestracja);
            this.panelLogowanie.Controls.Add(this.labelRejestracja);
            this.panelLogowanie.Controls.Add(this.btnLogowanie);
            this.panelLogowanie.Controls.Add(this.hasloTextBox);
            this.panelLogowanie.Controls.Add(this.loginTextBox);
            this.panelLogowanie.Controls.Add(this.labelHaslo);
            this.panelLogowanie.Controls.Add(this.labelLogin);
            this.panelLogowanie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogowanie.Location = new System.Drawing.Point(0, 80);
            this.panelLogowanie.Name = "panelLogowanie";
            this.panelLogowanie.Size = new System.Drawing.Size(480, 360);
            this.panelLogowanie.TabIndex = 3;
            // 
            // btnRejestracja
            // 
            this.btnRejestracja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRejestracja.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRejestracja.FlatAppearance.BorderSize = 2;
            this.btnRejestracja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRejestracja.Location = new System.Drawing.Point(348, 304);
            this.btnRejestracja.Name = "btnRejestracja";
            this.btnRejestracja.Size = new System.Drawing.Size(120, 40);
            this.btnRejestracja.TabIndex = 6;
            this.btnRejestracja.Text = "Rejestracja";
            this.btnRejestracja.UseVisualStyleBackColor = true;
            this.btnRejestracja.Click += new System.EventHandler(this.btnRejestracja_Click);
            // 
            // labelRejestracja
            // 
            this.labelRejestracja.AutoSize = true;
            this.labelRejestracja.Location = new System.Drawing.Point(179, 317);
            this.labelRejestracja.Name = "labelRejestracja";
            this.labelRejestracja.Size = new System.Drawing.Size(144, 17);
            this.labelRejestracja.TabIndex = 5;
            this.labelRejestracja.Text = "Nie posiadasz konta?";
            // 
            // btnLogowanie
            // 
            this.btnLogowanie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogowanie.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogowanie.FlatAppearance.BorderSize = 2;
            this.btnLogowanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogowanie.Location = new System.Drawing.Point(180, 210);
            this.btnLogowanie.Name = "btnLogowanie";
            this.btnLogowanie.Size = new System.Drawing.Size(120, 40);
            this.btnLogowanie.TabIndex = 4;
            this.btnLogowanie.Text = "Zaloguj się";
            this.btnLogowanie.UseVisualStyleBackColor = true;
            this.btnLogowanie.Click += new System.EventHandler(this.btnLogowanie_Click);
            // 
            // hasloTextBox
            // 
            this.hasloTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hasloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloTextBox.Location = new System.Drawing.Point(170, 150);
            this.hasloTextBox.Name = "hasloTextBox";
            this.hasloTextBox.PasswordChar = '*';
            this.hasloTextBox.Size = new System.Drawing.Size(150, 30);
            this.hasloTextBox.TabIndex = 3;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginTextBox.Location = new System.Drawing.Point(170, 50);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(150, 30);
            this.loginTextBox.TabIndex = 2;
            // 
            // labelHaslo
            // 
            this.labelHaslo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHaslo.AutoSize = true;
            this.labelHaslo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHaslo.Location = new System.Drawing.Point(209, 110);
            this.labelHaslo.Name = "labelHaslo";
            this.labelHaslo.Size = new System.Drawing.Size(62, 25);
            this.labelHaslo.TabIndex = 1;
            this.labelHaslo.Text = "Hasło";
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.AutoSize = true;
            this.labelLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(210, 10);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(60, 25);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // FormLogowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 440);
            this.Controls.Add(this.panelLogowanie);
            this.Controls.Add(this.panelTytul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.panelTytul.ResumeLayout(false);
            this.panelTytul.PerformLayout();
            this.panelLogowanie.ResumeLayout(false);
            this.panelLogowanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTytul;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Panel panelTytul;
        private System.Windows.Forms.Panel panelLogowanie;
        private System.Windows.Forms.Button btnMinimalizuj;
        private System.Windows.Forms.Button btnMaksymalizuj;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label labelHaslo;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button btnLogowanie;
        private System.Windows.Forms.TextBox hasloTextBox;
        private System.Windows.Forms.Button btnRejestracja;
        private System.Windows.Forms.Label labelRejestracja;
    }
}