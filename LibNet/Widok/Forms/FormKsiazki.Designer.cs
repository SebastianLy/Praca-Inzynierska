
namespace Widok
{
    partial class FormKsiazki
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
            this.panelFiltry = new System.Windows.Forms.Panel();
            this.szukajTextBox = new System.Windows.Forms.TextBox();
            this.szukajComboBox = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.panelTabela = new System.Windows.Forms.Panel();
            this.tabelaKsiazki = new System.Windows.Forms.DataGridView();
            this.panelPrzyciski = new System.Windows.Forms.Panel();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.panelFiltry.SuspendLayout();
            this.panelTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaKsiazki)).BeginInit();
            this.panelPrzyciski.SuspendLayout();
            this.SuspendLayout();
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
            this.panelFiltry.TabIndex = 2;
            // 
            // szukajTextBox
            // 
            this.szukajTextBox.Location = new System.Drawing.Point(227, 31);
            this.szukajTextBox.Name = "szukajTextBox";
            this.szukajTextBox.Size = new System.Drawing.Size(100, 22);
            this.szukajTextBox.TabIndex = 3;
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
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(81, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Wyszukaj w";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(340, 31);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(75, 23);
            this.btnSzukaj.TabIndex = 0;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            // 
            // panelTabela
            // 
            this.panelTabela.Controls.Add(this.tabelaKsiazki);
            this.panelTabela.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabela.Location = new System.Drawing.Point(0, 80);
            this.panelTabela.Name = "panelTabela";
            this.panelTabela.Size = new System.Drawing.Size(776, 376);
            this.panelTabela.TabIndex = 3;
            // 
            // tabelaKsiazki
            // 
            this.tabelaKsiazki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaKsiazki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaKsiazki.Location = new System.Drawing.Point(0, 0);
            this.tabelaKsiazki.Name = "tabelaKsiazki";
            this.tabelaKsiazki.ReadOnly = true;
            this.tabelaKsiazki.RowHeadersVisible = false;
            this.tabelaKsiazki.RowHeadersWidth = 51;
            this.tabelaKsiazki.RowTemplate.Height = 24;
            this.tabelaKsiazki.Size = new System.Drawing.Size(776, 376);
            this.tabelaKsiazki.TabIndex = 0;
            this.tabelaKsiazki.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaKsiazki_CellDoubleClick);
            // 
            // panelPrzyciski
            // 
            this.panelPrzyciski.Controls.Add(this.btnDodaj);
            this.panelPrzyciski.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrzyciski.Location = new System.Drawing.Point(0, 456);
            this.panelPrzyciski.Name = "panelPrzyciski";
            this.panelPrzyciski.Size = new System.Drawing.Size(776, 80);
            this.panelPrzyciski.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(600, 16);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(164, 43);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj Książkę";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FormKsiazki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 536);
            this.Controls.Add(this.panelPrzyciski);
            this.Controls.Add(this.panelTabela);
            this.Controls.Add(this.panelFiltry);
            this.Name = "FormKsiazki";
            this.Text = "FormKsiazki";
            this.Load += new System.EventHandler(this.FormKsiazki_Load);
            this.panelFiltry.ResumeLayout(false);
            this.panelFiltry.PerformLayout();
            this.panelTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaKsiazki)).EndInit();
            this.panelPrzyciski.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFiltry;
        private System.Windows.Forms.TextBox szukajTextBox;
        private System.Windows.Forms.ComboBox szukajComboBox;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Panel panelTabela;
        private System.Windows.Forms.DataGridView tabelaKsiazki;
        private System.Windows.Forms.Panel panelPrzyciski;
        private System.Windows.Forms.Button btnDodaj;
    }
}