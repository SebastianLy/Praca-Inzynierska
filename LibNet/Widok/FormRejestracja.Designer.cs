
namespace Widok
{
    partial class FormRejestracja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRejestracja));
            this.panelTytul = new System.Windows.Forms.Panel();
            this.btnMinimalizuj = new System.Windows.Forms.Button();
            this.btnMaksymalizuj = new System.Windows.Forms.Button();
            this.labelTytul = new System.Windows.Forms.Label();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.panelRejestracja = new System.Windows.Forms.Panel();
            this.btnLogowanie = new System.Windows.Forms.Button();
            this.kodPocztowyTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nrMieszkaniaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nrDomuTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ulicaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.miejscowoscTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.haslo2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hasloTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelTytul.SuspendLayout();
            this.panelRejestracja.SuspendLayout();
            this.SuspendLayout();
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
            this.panelTytul.Size = new System.Drawing.Size(686, 80);
            this.panelTytul.TabIndex = 3;
            // 
            // btnMinimalizuj
            // 
            this.btnMinimalizuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimalizuj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimalizuj.BackgroundImage")));
            this.btnMinimalizuj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimalizuj.FlatAppearance.BorderSize = 0;
            this.btnMinimalizuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimalizuj.Location = new System.Drawing.Point(599, 12);
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
            this.btnMaksymalizuj.Location = new System.Drawing.Point(626, 12);
            this.btnMaksymalizuj.Name = "btnMaksymalizuj";
            this.btnMaksymalizuj.Size = new System.Drawing.Size(21, 20);
            this.btnMaksymalizuj.TabIndex = 2;
            this.btnMaksymalizuj.UseVisualStyleBackColor = true;
            this.btnMaksymalizuj.Click += new System.EventHandler(this.btnMaksymalizuj_Click);
            // 
            // labelTytul
            // 
            this.labelTytul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTytul.AutoSize = true;
            this.labelTytul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTytul.Location = new System.Drawing.Point(270, 25);
            this.labelTytul.Name = "labelTytul";
            this.labelTytul.Size = new System.Drawing.Size(162, 31);
            this.labelTytul.TabIndex = 0;
            this.labelTytul.Text = "Rejestracja";
            // 
            // btnZamknij
            // 
            this.btnZamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZamknij.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZamknij.BackgroundImage")));
            this.btnZamknij.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZamknij.FlatAppearance.BorderSize = 0;
            this.btnZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZamknij.Location = new System.Drawing.Point(653, 12);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(21, 20);
            this.btnZamknij.TabIndex = 1;
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // panelRejestracja
            // 
            this.panelRejestracja.Controls.Add(this.btnLogowanie);
            this.panelRejestracja.Controls.Add(this.kodPocztowyTextBox);
            this.panelRejestracja.Controls.Add(this.label10);
            this.panelRejestracja.Controls.Add(this.nrMieszkaniaTextBox);
            this.panelRejestracja.Controls.Add(this.label8);
            this.panelRejestracja.Controls.Add(this.nrDomuTextBox);
            this.panelRejestracja.Controls.Add(this.label9);
            this.panelRejestracja.Controls.Add(this.ulicaTextBox);
            this.panelRejestracja.Controls.Add(this.label6);
            this.panelRejestracja.Controls.Add(this.miejscowoscTextBox);
            this.panelRejestracja.Controls.Add(this.label7);
            this.panelRejestracja.Controls.Add(this.nazwiskoTextBox);
            this.panelRejestracja.Controls.Add(this.label4);
            this.panelRejestracja.Controls.Add(this.imieTextBox);
            this.panelRejestracja.Controls.Add(this.label5);
            this.panelRejestracja.Controls.Add(this.haslo2TextBox);
            this.panelRejestracja.Controls.Add(this.label3);
            this.panelRejestracja.Controls.Add(this.hasloTextBox);
            this.panelRejestracja.Controls.Add(this.label2);
            this.panelRejestracja.Controls.Add(this.emailTextBox);
            this.panelRejestracja.Controls.Add(this.label1);
            this.panelRejestracja.Controls.Add(this.loginTextBox);
            this.panelRejestracja.Controls.Add(this.labelLogin);
            this.panelRejestracja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRejestracja.Location = new System.Drawing.Point(0, 80);
            this.panelRejestracja.Name = "panelRejestracja";
            this.panelRejestracja.Size = new System.Drawing.Size(686, 491);
            this.panelRejestracja.TabIndex = 4;
            // 
            // btnLogowanie
            // 
            this.btnLogowanie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogowanie.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogowanie.FlatAppearance.BorderSize = 2;
            this.btnLogowanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogowanie.Location = new System.Drawing.Point(256, 360);
            this.btnLogowanie.Name = "btnLogowanie";
            this.btnLogowanie.Size = new System.Drawing.Size(120, 40);
            this.btnLogowanie.TabIndex = 25;
            this.btnLogowanie.Text = "Zarejestruj się";
            this.btnLogowanie.UseVisualStyleBackColor = true;
            this.btnLogowanie.Click += new System.EventHandler(this.btnLogowanie_Click);
            // 
            // kodPocztowyTextBox
            // 
            this.kodPocztowyTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kodPocztowyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kodPocztowyTextBox.Location = new System.Drawing.Point(401, 280);
            this.kodPocztowyTextBox.Name = "kodPocztowyTextBox";
            this.kodPocztowyTextBox.Size = new System.Drawing.Size(150, 30);
            this.kodPocztowyTextBox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(407, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Kod pocztowy";
            // 
            // nrMieszkaniaTextBox
            // 
            this.nrMieszkaniaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrMieszkaniaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nrMieszkaniaTextBox.Location = new System.Drawing.Point(192, 280);
            this.nrMieszkaniaTextBox.Name = "nrMieszkaniaTextBox";
            this.nrMieszkaniaTextBox.Size = new System.Drawing.Size(150, 30);
            this.nrMieszkaniaTextBox.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(187, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Numer mieszkania";
            // 
            // nrDomuTextBox
            // 
            this.nrDomuTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrDomuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nrDomuTextBox.Location = new System.Drawing.Point(12, 280);
            this.nrDomuTextBox.Name = "nrDomuTextBox";
            this.nrDomuTextBox.Size = new System.Drawing.Size(150, 30);
            this.nrDomuTextBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(22, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Numer domu";
            // 
            // ulicaTextBox
            // 
            this.ulicaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ulicaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ulicaTextBox.Location = new System.Drawing.Point(524, 146);
            this.ulicaTextBox.Name = "ulicaTextBox";
            this.ulicaTextBox.Size = new System.Drawing.Size(150, 30);
            this.ulicaTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(569, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ulica";
            // 
            // miejscowoscTextBox
            // 
            this.miejscowoscTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.miejscowoscTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miejscowoscTextBox.Location = new System.Drawing.Point(356, 146);
            this.miejscowoscTextBox.Name = "miejscowoscTextBox";
            this.miejscowoscTextBox.Size = new System.Drawing.Size(150, 30);
            this.miejscowoscTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(366, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Miejscowość";
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nazwiskoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(181, 146);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(150, 30);
            this.nazwiskoTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(210, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nazwisko";
            // 
            // imieTextBox
            // 
            this.imieTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imieTextBox.Location = new System.Drawing.Point(12, 146);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(150, 30);
            this.imieTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(52, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Imię";
            // 
            // haslo2TextBox
            // 
            this.haslo2TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.haslo2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslo2TextBox.Location = new System.Drawing.Point(524, 54);
            this.haslo2TextBox.Name = "haslo2TextBox";
            this.haslo2TextBox.Size = new System.Drawing.Size(150, 30);
            this.haslo2TextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(529, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Powtórz hasło";
            // 
            // hasloTextBox
            // 
            this.hasloTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hasloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloTextBox.Location = new System.Drawing.Point(356, 54);
            this.hasloTextBox.Name = "hasloTextBox";
            this.hasloTextBox.Size = new System.Drawing.Size(150, 30);
            this.hasloTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(396, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasło";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTextBox.Location = new System.Drawing.Point(181, 54);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(150, 30);
            this.emailTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(221, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginTextBox.Location = new System.Drawing.Point(12, 54);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(150, 30);
            this.loginTextBox.TabIndex = 4;
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.AutoSize = true;
            this.labelLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(52, 14);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(60, 25);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login";
            // 
            // FormRejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 571);
            this.Controls.Add(this.panelRejestracja);
            this.Controls.Add(this.panelTytul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRejestracja";
            this.Text = "FormRejestracja";
            this.panelTytul.ResumeLayout(false);
            this.panelTytul.PerformLayout();
            this.panelRejestracja.ResumeLayout(false);
            this.panelRejestracja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTytul;
        private System.Windows.Forms.Button btnMinimalizuj;
        private System.Windows.Forms.Button btnMaksymalizuj;
        private System.Windows.Forms.Label labelTytul;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Panel panelRejestracja;
        private System.Windows.Forms.TextBox kodPocztowyTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nrMieszkaniaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nrDomuTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ulicaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox miejscowoscTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox haslo2TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hasloTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button btnLogowanie;
    }
}