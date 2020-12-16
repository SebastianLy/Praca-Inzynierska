
namespace Widok
{
    partial class FormDodajKsiazke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajKsiazke));
            this.panelTytul = new System.Windows.Forms.Panel();
            this.btnMinimalizuj = new System.Windows.Forms.Button();
            this.btnMaksymalizuj = new System.Windows.Forms.Button();
            this.labelTytul = new System.Windows.Forms.Label();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.panelZakladka = new System.Windows.Forms.Panel();
            this.miejsceWydaniaTextBox = new System.Windows.Forms.TextBox();
            this.wartoscTextBox = new System.Windows.Forms.TextBox();
            this.wydawcaTextBox = new System.Windows.Forms.TextBox();
            this.dataWydaniaTextBox = new System.Windows.Forms.TextBox();
            this.gatunekTextBox = new System.Windows.Forms.TextBox();
            this.tytulTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.sygnaturaTextBox = new System.Windows.Forms.TextBox();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTytul.SuspendLayout();
            this.panelZakladka.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTytul
            // 
            this.panelTytul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTytul.Controls.Add(this.btnMinimalizuj);
            this.panelTytul.Controls.Add(this.btnMaksymalizuj);
            this.panelTytul.Controls.Add(this.labelTytul);
            this.panelTytul.Controls.Add(this.btnZamknij);
            this.panelTytul.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTytul.Location = new System.Drawing.Point(0, 0);
            this.panelTytul.Name = "panelTytul";
            this.panelTytul.Size = new System.Drawing.Size(580, 80);
            this.panelTytul.TabIndex = 3;
            this.panelTytul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTytul_MouseDown);
            // 
            // btnMinimalizuj
            // 
            this.btnMinimalizuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimalizuj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimalizuj.BackgroundImage")));
            this.btnMinimalizuj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimalizuj.FlatAppearance.BorderSize = 0;
            this.btnMinimalizuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimalizuj.Location = new System.Drawing.Point(493, 12);
            this.btnMinimalizuj.Name = "btnMinimalizuj";
            this.btnMinimalizuj.Size = new System.Drawing.Size(21, 20);
            this.btnMinimalizuj.TabIndex = 0;
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
            this.btnMaksymalizuj.Location = new System.Drawing.Point(520, 12);
            this.btnMaksymalizuj.Name = "btnMaksymalizuj";
            this.btnMaksymalizuj.Size = new System.Drawing.Size(21, 20);
            this.btnMaksymalizuj.TabIndex = 1;
            this.btnMaksymalizuj.UseVisualStyleBackColor = true;
            this.btnMaksymalizuj.Click += new System.EventHandler(this.btnMaksymalizuj_Click);
            // 
            // labelTytul
            // 
            this.labelTytul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTytul.AutoSize = true;
            this.labelTytul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTytul.Location = new System.Drawing.Point(217, 25);
            this.labelTytul.Name = "labelTytul";
            this.labelTytul.Size = new System.Drawing.Size(117, 31);
            this.labelTytul.TabIndex = 0;
            this.labelTytul.Text = "Książka";
            // 
            // btnZamknij
            // 
            this.btnZamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZamknij.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZamknij.BackgroundImage")));
            this.btnZamknij.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZamknij.FlatAppearance.BorderSize = 0;
            this.btnZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZamknij.Location = new System.Drawing.Point(547, 12);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(21, 20);
            this.btnZamknij.TabIndex = 2;
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // panelZakladka
            // 
            this.panelZakladka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelZakladka.Controls.Add(this.miejsceWydaniaTextBox);
            this.panelZakladka.Controls.Add(this.wartoscTextBox);
            this.panelZakladka.Controls.Add(this.wydawcaTextBox);
            this.panelZakladka.Controls.Add(this.dataWydaniaTextBox);
            this.panelZakladka.Controls.Add(this.gatunekTextBox);
            this.panelZakladka.Controls.Add(this.tytulTextBox);
            this.panelZakladka.Controls.Add(this.autorTextBox);
            this.panelZakladka.Controls.Add(this.sygnaturaTextBox);
            this.panelZakladka.Controls.Add(this.btnUsun);
            this.panelZakladka.Controls.Add(this.btnEdytuj);
            this.panelZakladka.Controls.Add(this.btnDodaj);
            this.panelZakladka.Controls.Add(this.label8);
            this.panelZakladka.Controls.Add(this.label6);
            this.panelZakladka.Controls.Add(this.label7);
            this.panelZakladka.Controls.Add(this.label5);
            this.panelZakladka.Controls.Add(this.label4);
            this.panelZakladka.Controls.Add(this.label3);
            this.panelZakladka.Controls.Add(this.label2);
            this.panelZakladka.Controls.Add(this.label1);
            this.panelZakladka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelZakladka.Location = new System.Drawing.Point(0, 80);
            this.panelZakladka.Name = "panelZakladka";
            this.panelZakladka.Size = new System.Drawing.Size(580, 362);
            this.panelZakladka.TabIndex = 4;
            // 
            // miejsceWydaniaTextBox
            // 
            this.miejsceWydaniaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.miejsceWydaniaTextBox.Location = new System.Drawing.Point(292, 185);
            this.miejsceWydaniaTextBox.MaxLength = 255;
            this.miejsceWydaniaTextBox.Name = "miejsceWydaniaTextBox";
            this.miejsceWydaniaTextBox.Size = new System.Drawing.Size(150, 22);
            this.miejsceWydaniaTextBox.TabIndex = 5;
            // 
            // wartoscTextBox
            // 
            this.wartoscTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wartoscTextBox.Location = new System.Drawing.Point(292, 255);
            this.wartoscTextBox.MaxLength = 20;
            this.wartoscTextBox.Name = "wartoscTextBox";
            this.wartoscTextBox.Size = new System.Drawing.Size(150, 22);
            this.wartoscTextBox.TabIndex = 7;
            // 
            // wydawcaTextBox
            // 
            this.wydawcaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wydawcaTextBox.Location = new System.Drawing.Point(292, 150);
            this.wydawcaTextBox.MaxLength = 255;
            this.wydawcaTextBox.Name = "wydawcaTextBox";
            this.wydawcaTextBox.Size = new System.Drawing.Size(150, 22);
            this.wydawcaTextBox.TabIndex = 4;
            // 
            // dataWydaniaTextBox
            // 
            this.dataWydaniaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataWydaniaTextBox.Location = new System.Drawing.Point(292, 220);
            this.dataWydaniaTextBox.MaxLength = 4;
            this.dataWydaniaTextBox.Name = "dataWydaniaTextBox";
            this.dataWydaniaTextBox.Size = new System.Drawing.Size(150, 22);
            this.dataWydaniaTextBox.TabIndex = 6;
            // 
            // gatunekTextBox
            // 
            this.gatunekTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gatunekTextBox.Location = new System.Drawing.Point(292, 115);
            this.gatunekTextBox.MaxLength = 255;
            this.gatunekTextBox.Name = "gatunekTextBox";
            this.gatunekTextBox.Size = new System.Drawing.Size(150, 22);
            this.gatunekTextBox.TabIndex = 3;
            // 
            // tytulTextBox
            // 
            this.tytulTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tytulTextBox.Location = new System.Drawing.Point(292, 45);
            this.tytulTextBox.MaxLength = 255;
            this.tytulTextBox.Name = "tytulTextBox";
            this.tytulTextBox.Size = new System.Drawing.Size(150, 22);
            this.tytulTextBox.TabIndex = 1;
            // 
            // autorTextBox
            // 
            this.autorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.autorTextBox.Location = new System.Drawing.Point(292, 80);
            this.autorTextBox.MaxLength = 255;
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(150, 22);
            this.autorTextBox.TabIndex = 2;
            // 
            // sygnaturaTextBox
            // 
            this.sygnaturaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sygnaturaTextBox.Location = new System.Drawing.Point(292, 10);
            this.sygnaturaTextBox.MaxLength = 63;
            this.sygnaturaTextBox.Name = "sygnaturaTextBox";
            this.sygnaturaTextBox.Size = new System.Drawing.Size(150, 22);
            this.sygnaturaTextBox.TabIndex = 0;
            // 
            // btnUsun
            // 
            this.btnUsun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsun.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnUsun.FlatAppearance.BorderSize = 2;
            this.btnUsun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsun.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsun.Location = new System.Drawing.Point(15, 300);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(164, 43);
            this.btnUsun.TabIndex = 8;
            this.btnUsun.Text = "Usuń książkę";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdytuj.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnEdytuj.FlatAppearance.BorderSize = 2;
            this.btnEdytuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdytuj.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEdytuj.Location = new System.Drawing.Point(204, 300);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(164, 43);
            this.btnEdytuj.TabIndex = 9;
            this.btnEdytuj.Text = "Edytuj książkę";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnDodaj.FlatAppearance.BorderSize = 2;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDodaj.Location = new System.Drawing.Point(392, 300);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(164, 43);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj książkę";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(130, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Wartość:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(130, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Miejsce wydania:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(130, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Data wydania:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(130, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wydawca:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(130, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gatunek:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(130, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(130, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tytuł:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(130, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sygnatura:";
            // 
            // FormDodajKsiazke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 442);
            this.Controls.Add(this.panelZakladka);
            this.Controls.Add(this.panelTytul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDodajKsiazke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDodajKsiazke";
            this.panelTytul.ResumeLayout(false);
            this.panelTytul.PerformLayout();
            this.panelZakladka.ResumeLayout(false);
            this.panelZakladka.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTytul;
        private System.Windows.Forms.Button btnMinimalizuj;
        private System.Windows.Forms.Button btnMaksymalizuj;
        private System.Windows.Forms.Label labelTytul;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Panel panelZakladka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox miejsceWydaniaTextBox;
        private System.Windows.Forms.TextBox wartoscTextBox;
        private System.Windows.Forms.TextBox wydawcaTextBox;
        private System.Windows.Forms.TextBox dataWydaniaTextBox;
        private System.Windows.Forms.TextBox gatunekTextBox;
        private System.Windows.Forms.TextBox tytulTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox sygnaturaTextBox;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnDodaj;
    }
}