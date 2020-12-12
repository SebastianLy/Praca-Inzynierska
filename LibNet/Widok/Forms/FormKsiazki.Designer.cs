
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFiltry = new System.Windows.Forms.Panel();
            this.szukajTextBox = new System.Windows.Forms.TextBox();
            this.szukajComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.panelTabela = new System.Windows.Forms.Panel();
            this.tabelaKsiazki = new System.Windows.Forms.DataGridView();
            this.panelPrzyciski = new System.Windows.Forms.Panel();
            this.btnRezerwacja = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.panelFiltry.SuspendLayout();
            this.panelTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaKsiazki)).BeginInit();
            this.panelPrzyciski.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFiltry
            // 
            this.panelFiltry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panelFiltry.Controls.Add(this.szukajTextBox);
            this.panelFiltry.Controls.Add(this.szukajComboBox);
            this.panelFiltry.Controls.Add(this.label1);
            this.panelFiltry.Controls.Add(this.btnSzukaj);
            this.panelFiltry.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltry.Location = new System.Drawing.Point(0, 0);
            this.panelFiltry.Name = "panelFiltry";
            this.panelFiltry.Size = new System.Drawing.Size(776, 65);
            this.panelFiltry.TabIndex = 2;
            // 
            // szukajTextBox
            // 
            this.szukajTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szukajTextBox.Location = new System.Drawing.Point(302, 19);
            this.szukajTextBox.MaxLength = 255;
            this.szukajTextBox.Name = "szukajTextBox";
            this.szukajTextBox.Size = new System.Drawing.Size(140, 24);
            this.szukajTextBox.TabIndex = 1;
            // 
            // szukajComboBox
            // 
            this.szukajComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.szukajComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.szukajComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.szukajComboBox.Items.AddRange(new object[] {
            "Sygnatura",
            "Tytuł",
            "Autor",
            "Gatunek",
            "Wydanie",
            "Wartość",
            "Przetrzymujący"});
            this.szukajComboBox.Location = new System.Drawing.Point(143, 19);
            this.szukajComboBox.Name = "szukajComboBox";
            this.szukajComboBox.Size = new System.Drawing.Size(140, 24);
            this.szukajComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wyszukaj w:";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSzukaj.FlatAppearance.BorderSize = 2;
            this.btnSzukaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukaj.ForeColor = System.Drawing.Color.Black;
            this.btnSzukaj.Location = new System.Drawing.Point(461, 11);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(164, 43);
            this.btnSzukaj.TabIndex = 2;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // panelTabela
            // 
            this.panelTabela.Controls.Add(this.tabelaKsiazki);
            this.panelTabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabela.Location = new System.Drawing.Point(0, 65);
            this.panelTabela.Name = "panelTabela";
            this.panelTabela.Size = new System.Drawing.Size(776, 471);
            this.panelTabela.TabIndex = 3;
            // 
            // tabelaKsiazki
            // 
            this.tabelaKsiazki.AllowUserToAddRows = false;
            this.tabelaKsiazki.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaKsiazki.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaKsiazki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaKsiazki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaKsiazki.Location = new System.Drawing.Point(0, 0);
            this.tabelaKsiazki.Name = "tabelaKsiazki";
            this.tabelaKsiazki.ReadOnly = true;
            this.tabelaKsiazki.RowHeadersVisible = false;
            this.tabelaKsiazki.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabelaKsiazki.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaKsiazki.RowTemplate.Height = 24;
            this.tabelaKsiazki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tabelaKsiazki.Size = new System.Drawing.Size(776, 471);
            this.tabelaKsiazki.TabIndex = 5;
            this.tabelaKsiazki.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaKsiazki_CellDoubleClick);
            this.tabelaKsiazki.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tabelaKsiazki_DataBindingComplete);
            // 
            // panelPrzyciski
            // 
            this.panelPrzyciski.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panelPrzyciski.Controls.Add(this.btnRezerwacja);
            this.panelPrzyciski.Controls.Add(this.btnDodaj);
            this.panelPrzyciski.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPrzyciski.Location = new System.Drawing.Point(0, 468);
            this.panelPrzyciski.Name = "panelPrzyciski";
            this.panelPrzyciski.Size = new System.Drawing.Size(776, 68);
            this.panelPrzyciski.TabIndex = 4;
            // 
            // btnRezerwacja
            // 
            this.btnRezerwacja.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRezerwacja.FlatAppearance.BorderSize = 2;
            this.btnRezerwacja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezerwacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRezerwacja.ForeColor = System.Drawing.Color.Black;
            this.btnRezerwacja.Location = new System.Drawing.Point(16, 13);
            this.btnRezerwacja.Name = "btnRezerwacja";
            this.btnRezerwacja.Size = new System.Drawing.Size(200, 43);
            this.btnRezerwacja.TabIndex = 3;
            this.btnRezerwacja.Text = "Zarezerwuj książkę";
            this.btnRezerwacja.UseVisualStyleBackColor = true;
            this.btnRezerwacja.Click += new System.EventHandler(this.btnRezerwacja_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDodaj.FlatAppearance.BorderSize = 2;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.Color.Black;
            this.btnDodaj.Location = new System.Drawing.Point(564, 13);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(200, 43);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj książkę";
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
        private System.Windows.Forms.Panel panelTabela;
        private System.Windows.Forms.DataGridView tabelaKsiazki;
        private System.Windows.Forms.Panel panelPrzyciski;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox szukajTextBox;
        private System.Windows.Forms.ComboBox szukajComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Button btnRezerwacja;
    }
}