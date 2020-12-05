
namespace Widok
{
    partial class FormUzytkownicy
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
            this.tabelaUzytkownicy = new System.Windows.Forms.DataGridView();
            this.panelFiltry = new System.Windows.Forms.Panel();
            this.panelTabela = new System.Windows.Forms.Panel();
            this.panelPrzyciski = new System.Windows.Forms.Panel();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.szukajComboBox = new System.Windows.Forms.ComboBox();
            this.szukajTextBox = new System.Windows.Forms.TextBox();
            this.btnBlokada = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.powodTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaUzytkownicy)).BeginInit();
            this.panelFiltry.SuspendLayout();
            this.panelTabela.SuspendLayout();
            this.panelPrzyciski.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelaUzytkownicy
            // 
            this.tabelaUzytkownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaUzytkownicy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaUzytkownicy.Location = new System.Drawing.Point(0, 0);
            this.tabelaUzytkownicy.Name = "tabelaUzytkownicy";
            this.tabelaUzytkownicy.ReadOnly = true;
            this.tabelaUzytkownicy.RowHeadersVisible = false;
            this.tabelaUzytkownicy.RowHeadersWidth = 51;
            this.tabelaUzytkownicy.RowTemplate.Height = 24;
            this.tabelaUzytkownicy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaUzytkownicy.Size = new System.Drawing.Size(776, 376);
            this.tabelaUzytkownicy.TabIndex = 0;
            this.tabelaUzytkownicy.SelectionChanged += new System.EventHandler(this.tabelaUzytkownicy_SelectionChanged);
            // 
            // panelFiltry
            // 
            this.panelFiltry.Controls.Add(this.szukajTextBox);
            this.panelFiltry.Controls.Add(this.szukajComboBox);
            this.panelFiltry.Controls.Add(this.lbl1);
            this.panelFiltry.Controls.Add(this.btnSzukaj);
            this.panelFiltry.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltry.Location = new System.Drawing.Point(0, 0);
            this.panelFiltry.Name = "panelFiltry";
            this.panelFiltry.Size = new System.Drawing.Size(776, 80);
            this.panelFiltry.TabIndex = 1;
            // 
            // panelTabela
            // 
            this.panelTabela.Controls.Add(this.tabelaUzytkownicy);
            this.panelTabela.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabela.Location = new System.Drawing.Point(0, 80);
            this.panelTabela.Name = "panelTabela";
            this.panelTabela.Size = new System.Drawing.Size(776, 376);
            this.panelTabela.TabIndex = 2;
            // 
            // panelPrzyciski
            // 
            this.panelPrzyciski.Controls.Add(this.powodTextBox);
            this.panelPrzyciski.Controls.Add(this.btnUsun);
            this.panelPrzyciski.Controls.Add(this.btnBlokada);
            this.panelPrzyciski.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrzyciski.Location = new System.Drawing.Point(0, 456);
            this.panelPrzyciski.Name = "panelPrzyciski";
            this.panelPrzyciski.Size = new System.Drawing.Size(776, 80);
            this.panelPrzyciski.TabIndex = 3;
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(340, 31);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(75, 23);
            this.btnSzukaj.TabIndex = 0;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(81, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Wyszukaj w";
            // 
            // szukajComboBox
            // 
            this.szukajComboBox.FormattingEnabled = true;
            this.szukajComboBox.Items.AddRange(new object[] {
            "Imię/Nazwisko",
            "Adres"});
            this.szukajComboBox.Location = new System.Drawing.Point(100, 31);
            this.szukajComboBox.Name = "szukajComboBox";
            this.szukajComboBox.Size = new System.Drawing.Size(121, 24);
            this.szukajComboBox.TabIndex = 2;
            // 
            // szukajTextBox
            // 
            this.szukajTextBox.Location = new System.Drawing.Point(227, 31);
            this.szukajTextBox.Name = "szukajTextBox";
            this.szukajTextBox.Size = new System.Drawing.Size(100, 22);
            this.szukajTextBox.TabIndex = 3;
            // 
            // btnBlokada
            // 
            this.btnBlokada.Enabled = false;
            this.btnBlokada.Location = new System.Drawing.Point(251, 16);
            this.btnBlokada.Name = "btnBlokada";
            this.btnBlokada.Size = new System.Drawing.Size(164, 43);
            this.btnBlokada.TabIndex = 0;
            this.btnBlokada.Text = "Zablokuj/Odblokuj";
            this.btnBlokada.UseVisualStyleBackColor = true;
            this.btnBlokada.Click += new System.EventHandler(this.btnBlokada_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Enabled = false;
            this.btnUsun.Location = new System.Drawing.Point(600, 16);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(164, 43);
            this.btnUsun.TabIndex = 1;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // powodTextBox
            // 
            this.powodTextBox.Location = new System.Drawing.Point(13, 16);
            this.powodTextBox.Multiline = true;
            this.powodTextBox.Name = "powodTextBox";
            this.powodTextBox.Size = new System.Drawing.Size(208, 52);
            this.powodTextBox.TabIndex = 2;
            // 
            // FormUzytkownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 536);
            this.Controls.Add(this.panelPrzyciski);
            this.Controls.Add(this.panelTabela);
            this.Controls.Add(this.panelFiltry);
            this.Name = "FormUzytkownicy";
            this.Text = "FormUzytkownicy";
            this.Load += new System.EventHandler(this.FormUzytkownicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaUzytkownicy)).EndInit();
            this.panelFiltry.ResumeLayout(false);
            this.panelFiltry.PerformLayout();
            this.panelTabela.ResumeLayout(false);
            this.panelPrzyciski.ResumeLayout(false);
            this.panelPrzyciski.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelaUzytkownicy;
        private System.Windows.Forms.Panel panelFiltry;
        private System.Windows.Forms.Panel panelTabela;
        private System.Windows.Forms.Panel panelPrzyciski;
        private System.Windows.Forms.TextBox szukajTextBox;
        private System.Windows.Forms.ComboBox szukajComboBox;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnBlokada;
        private System.Windows.Forms.TextBox powodTextBox;
    }
}