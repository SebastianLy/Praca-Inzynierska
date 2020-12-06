
namespace Widok
{
    partial class formMenuGlowne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenuGlowne));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPlatnosci = new System.Windows.Forms.Button();
            this.btnWypozyczalnia = new System.Windows.Forms.Button();
            this.btnKsiazki = new System.Windows.Forms.Button();
            this.btnUzytkownicy = new System.Windows.Forms.Button();
            this.btnBiblioteka = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.panelTytul = new System.Windows.Forms.Panel();
            this.btnMinimalizuj = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnMaksymalizuj = new System.Windows.Forms.Button();
            this.lblTytul = new System.Windows.Forms.Label();
            this.panelZakladka = new System.Windows.Forms.Panel();
            this.labelZegar = new System.Windows.Forms.Label();
            this.labelZakladkaLogo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTytul.SuspendLayout();
            this.panelZakladka.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(220)))));
            this.panelMenu.Controls.Add(this.btnPlatnosci);
            this.panelMenu.Controls.Add(this.btnWypozyczalnia);
            this.panelMenu.Controls.Add(this.btnKsiazki);
            this.panelMenu.Controls.Add(this.btnUzytkownicy);
            this.panelMenu.Controls.Add(this.btnBiblioteka);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 618);
            this.panelMenu.TabIndex = 0;
            // 
            // btnPlatnosci
            // 
            this.btnPlatnosci.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlatnosci.FlatAppearance.BorderSize = 0;
            this.btnPlatnosci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlatnosci.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPlatnosci.Image = ((System.Drawing.Image)(resources.GetObject("btnPlatnosci.Image")));
            this.btnPlatnosci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlatnosci.Location = new System.Drawing.Point(0, 480);
            this.btnPlatnosci.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlatnosci.Name = "btnPlatnosci";
            this.btnPlatnosci.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnPlatnosci.Size = new System.Drawing.Size(260, 100);
            this.btnPlatnosci.TabIndex = 5;
            this.btnPlatnosci.Text = "     Płatności";
            this.btnPlatnosci.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlatnosci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlatnosci.UseVisualStyleBackColor = true;
            this.btnPlatnosci.Click += new System.EventHandler(this.btnPlatnosci_Click);
            // 
            // btnWypozyczalnia
            // 
            this.btnWypozyczalnia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWypozyczalnia.FlatAppearance.BorderSize = 0;
            this.btnWypozyczalnia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWypozyczalnia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnWypozyczalnia.Image = ((System.Drawing.Image)(resources.GetObject("btnWypozyczalnia.Image")));
            this.btnWypozyczalnia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWypozyczalnia.Location = new System.Drawing.Point(0, 380);
            this.btnWypozyczalnia.Margin = new System.Windows.Forms.Padding(4);
            this.btnWypozyczalnia.Name = "btnWypozyczalnia";
            this.btnWypozyczalnia.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnWypozyczalnia.Size = new System.Drawing.Size(260, 100);
            this.btnWypozyczalnia.TabIndex = 4;
            this.btnWypozyczalnia.Text = "     Wypożyczalnia";
            this.btnWypozyczalnia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWypozyczalnia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWypozyczalnia.UseVisualStyleBackColor = true;
            this.btnWypozyczalnia.Click += new System.EventHandler(this.btnWypozyczalnia_Click);
            // 
            // btnKsiazki
            // 
            this.btnKsiazki.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKsiazki.FlatAppearance.BorderSize = 0;
            this.btnKsiazki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKsiazki.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnKsiazki.Image = ((System.Drawing.Image)(resources.GetObject("btnKsiazki.Image")));
            this.btnKsiazki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKsiazki.Location = new System.Drawing.Point(0, 280);
            this.btnKsiazki.Margin = new System.Windows.Forms.Padding(4);
            this.btnKsiazki.Name = "btnKsiazki";
            this.btnKsiazki.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnKsiazki.Size = new System.Drawing.Size(260, 100);
            this.btnKsiazki.TabIndex = 3;
            this.btnKsiazki.Text = "     Książki";
            this.btnKsiazki.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKsiazki.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKsiazki.UseVisualStyleBackColor = true;
            this.btnKsiazki.Click += new System.EventHandler(this.btnKsiazki_Click);
            // 
            // btnUzytkownicy
            // 
            this.btnUzytkownicy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUzytkownicy.FlatAppearance.BorderSize = 0;
            this.btnUzytkownicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUzytkownicy.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUzytkownicy.Image = ((System.Drawing.Image)(resources.GetObject("btnUzytkownicy.Image")));
            this.btnUzytkownicy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUzytkownicy.Location = new System.Drawing.Point(0, 180);
            this.btnUzytkownicy.Margin = new System.Windows.Forms.Padding(4);
            this.btnUzytkownicy.Name = "btnUzytkownicy";
            this.btnUzytkownicy.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnUzytkownicy.Size = new System.Drawing.Size(260, 100);
            this.btnUzytkownicy.TabIndex = 2;
            this.btnUzytkownicy.Text = "     Użytkownicy";
            this.btnUzytkownicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUzytkownicy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUzytkownicy.UseVisualStyleBackColor = true;
            this.btnUzytkownicy.Click += new System.EventHandler(this.btnUzytkownicy_Click);
            // 
            // btnBiblioteka
            // 
            this.btnBiblioteka.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBiblioteka.FlatAppearance.BorderSize = 0;
            this.btnBiblioteka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiblioteka.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBiblioteka.Image = ((System.Drawing.Image)(resources.GetObject("btnBiblioteka.Image")));
            this.btnBiblioteka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiblioteka.Location = new System.Drawing.Point(0, 80);
            this.btnBiblioteka.Margin = new System.Windows.Forms.Padding(4);
            this.btnBiblioteka.Name = "btnBiblioteka";
            this.btnBiblioteka.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnBiblioteka.Size = new System.Drawing.Size(260, 100);
            this.btnBiblioteka.TabIndex = 1;
            this.btnBiblioteka.Text = "     Biblioteka";
            this.btnBiblioteka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiblioteka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBiblioteka.UseVisualStyleBackColor = true;
            this.btnBiblioteka.Click += new System.EventHandler(this.btnBiblioteka_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(10)))), ((int)(((byte)(133)))));
            this.panelLogo.Controls.Add(this.lblNazwa);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(260, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblNazwa
            // 
            this.lblNazwa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwa.Location = new System.Drawing.Point(80, 25);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(99, 31);
            this.lblNazwa.TabIndex = 0;
            this.lblNazwa.Text = "LibNet";
            this.lblNazwa.Click += new System.EventHandler(this.lblNazwa_Click);
            // 
            // panelTytul
            // 
            this.panelTytul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTytul.Controls.Add(this.btnMinimalizuj);
            this.panelTytul.Controls.Add(this.btnZamknij);
            this.panelTytul.Controls.Add(this.btnMaksymalizuj);
            this.panelTytul.Controls.Add(this.lblTytul);
            this.panelTytul.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTytul.Location = new System.Drawing.Point(260, 0);
            this.panelTytul.Name = "panelTytul";
            this.panelTytul.Size = new System.Drawing.Size(1006, 80);
            this.panelTytul.TabIndex = 1;
            this.panelTytul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTytul_MouseDown);
            // 
            // btnMinimalizuj
            // 
            this.btnMinimalizuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimalizuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMinimalizuj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimalizuj.BackgroundImage")));
            this.btnMinimalizuj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimalizuj.FlatAppearance.BorderSize = 0;
            this.btnMinimalizuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimalizuj.Location = new System.Drawing.Point(919, 10);
            this.btnMinimalizuj.Name = "btnMinimalizuj";
            this.btnMinimalizuj.Size = new System.Drawing.Size(21, 20);
            this.btnMinimalizuj.TabIndex = 3;
            this.btnMinimalizuj.UseVisualStyleBackColor = true;
            this.btnMinimalizuj.Click += new System.EventHandler(this.btnMinimalizuj_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZamknij.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnZamknij.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZamknij.BackgroundImage")));
            this.btnZamknij.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZamknij.FlatAppearance.BorderSize = 0;
            this.btnZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZamknij.Location = new System.Drawing.Point(973, 10);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(21, 20);
            this.btnZamknij.TabIndex = 1;
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnMaksymalizuj
            // 
            this.btnMaksymalizuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaksymalizuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMaksymalizuj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaksymalizuj.BackgroundImage")));
            this.btnMaksymalizuj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaksymalizuj.FlatAppearance.BorderSize = 0;
            this.btnMaksymalizuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaksymalizuj.Location = new System.Drawing.Point(946, 10);
            this.btnMaksymalizuj.Name = "btnMaksymalizuj";
            this.btnMaksymalizuj.Size = new System.Drawing.Size(21, 20);
            this.btnMaksymalizuj.TabIndex = 2;
            this.btnMaksymalizuj.UseVisualStyleBackColor = true;
            this.btnMaksymalizuj.Click += new System.EventHandler(this.btnMaksymalizuj_Click);
            // 
            // lblTytul
            // 
            this.lblTytul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTytul.AutoSize = true;
            this.lblTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTytul.Location = new System.Drawing.Point(457, 25);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(99, 31);
            this.lblTytul.TabIndex = 0;
            this.lblTytul.Text = "HOME";
            // 
            // panelZakladka
            // 
            this.panelZakladka.Controls.Add(this.labelZegar);
            this.panelZakladka.Controls.Add(this.labelZakladkaLogo);
            this.panelZakladka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelZakladka.Location = new System.Drawing.Point(260, 80);
            this.panelZakladka.Name = "panelZakladka";
            this.panelZakladka.Size = new System.Drawing.Size(1006, 538);
            this.panelZakladka.TabIndex = 2;
            // 
            // labelZegar
            // 
            this.labelZegar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZegar.AutoSize = true;
            this.labelZegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZegar.Location = new System.Drawing.Point(425, 316);
            this.labelZegar.Name = "labelZegar";
            this.labelZegar.Size = new System.Drawing.Size(90, 31);
            this.labelZegar.TabIndex = 2;
            this.labelZegar.Text = "Zegar";
            // 
            // labelZakladkaLogo
            // 
            this.labelZakladkaLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZakladkaLogo.AutoSize = true;
            this.labelZakladkaLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZakladkaLogo.Location = new System.Drawing.Point(460, 256);
            this.labelZakladkaLogo.Name = "labelZakladkaLogo";
            this.labelZakladkaLogo.Size = new System.Drawing.Size(99, 31);
            this.labelZakladkaLogo.TabIndex = 1;
            this.labelZakladkaLogo.Text = "LibNet";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formMenuGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 618);
            this.Controls.Add(this.panelZakladka);
            this.Controls.Add(this.panelTytul);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1000, 618);
            this.Name = "formMenuGlowne";
            this.Text = "LibNet";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTytul.ResumeLayout(false);
            this.panelTytul.PerformLayout();
            this.panelZakladka.ResumeLayout(false);
            this.panelZakladka.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPlatnosci;
        private System.Windows.Forms.Button btnWypozyczalnia;
        private System.Windows.Forms.Button btnKsiazki;
        private System.Windows.Forms.Button btnUzytkownicy;
        private System.Windows.Forms.Button btnBiblioteka;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTytul;
        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Panel panelZakladka;
        private System.Windows.Forms.Button btnMinimalizuj;
        private System.Windows.Forms.Button btnMaksymalizuj;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Label labelZegar;
        private System.Windows.Forms.Label labelZakladkaLogo;
        private System.Windows.Forms.Timer timer1;
    }
}

