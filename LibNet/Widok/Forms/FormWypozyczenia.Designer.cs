
namespace Widok
{
    partial class FormWypozyczenia
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
            this.panelPrzyciski = new System.Windows.Forms.Panel();
            this.btnZwroc = new System.Windows.Forms.Button();
            this.sygnaturyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.wypozyczajacyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWypozycz = new System.Windows.Forms.Button();
            this.panelTabela = new System.Windows.Forms.Panel();
            this.tabelaWypozyczenia = new System.Windows.Forms.DataGridView();
            this.panelFiltry.SuspendLayout();
            this.panelPrzyciski.SuspendLayout();
            this.panelTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaWypozyczenia)).BeginInit();
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
            "ID Wypożyczenia",
            "Data Wypożyczenia",
            "Data Zwrotu",
            "Wypożyczający",
            "Sygnatura",
            "Tytuł"});
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
            this.label1.TabIndex = 1;
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
            // panelPrzyciski
            // 
            this.panelPrzyciski.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panelPrzyciski.Controls.Add(this.btnZwroc);
            this.panelPrzyciski.Controls.Add(this.sygnaturyTextBox);
            this.panelPrzyciski.Controls.Add(this.label3);
            this.panelPrzyciski.Controls.Add(this.wypozyczajacyTextBox);
            this.panelPrzyciski.Controls.Add(this.label2);
            this.panelPrzyciski.Controls.Add(this.btnWypozycz);
            this.panelPrzyciski.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPrzyciski.Location = new System.Drawing.Point(0, 416);
            this.panelPrzyciski.Name = "panelPrzyciski";
            this.panelPrzyciski.Size = new System.Drawing.Size(776, 120);
            this.panelPrzyciski.TabIndex = 3;
            // 
            // btnZwroc
            // 
            this.btnZwroc.Enabled = false;
            this.btnZwroc.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnZwroc.FlatAppearance.BorderSize = 2;
            this.btnZwroc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZwroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZwroc.ForeColor = System.Drawing.Color.Black;
            this.btnZwroc.Location = new System.Drawing.Point(549, 41);
            this.btnZwroc.Name = "btnZwroc";
            this.btnZwroc.Size = new System.Drawing.Size(200, 43);
            this.btnZwroc.TabIndex = 6;
            this.btnZwroc.Text = "Zwróć";
            this.btnZwroc.UseVisualStyleBackColor = true;
            this.btnZwroc.Click += new System.EventHandler(this.btnZwroc_Click);
            // 
            // sygnaturyTextBox
            // 
            this.sygnaturyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sygnaturyTextBox.Location = new System.Drawing.Point(162, 71);
            this.sygnaturyTextBox.MaxLength = 63;
            this.sygnaturyTextBox.Name = "sygnaturyTextBox";
            this.sygnaturyTextBox.Size = new System.Drawing.Size(140, 24);
            this.sygnaturyTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sygnatury:";
            // 
            // wypozyczajacyTextBox
            // 
            this.wypozyczajacyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wypozyczajacyTextBox.Location = new System.Drawing.Point(162, 27);
            this.wypozyczajacyTextBox.MaxLength = 63;
            this.wypozyczajacyTextBox.Name = "wypozyczajacyTextBox";
            this.wypozyczajacyTextBox.Size = new System.Drawing.Size(140, 24);
            this.wypozyczajacyTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wypożyczający:";
            // 
            // btnWypozycz
            // 
            this.btnWypozycz.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnWypozycz.FlatAppearance.BorderSize = 2;
            this.btnWypozycz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWypozycz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWypozycz.ForeColor = System.Drawing.Color.Black;
            this.btnWypozycz.Location = new System.Drawing.Point(327, 41);
            this.btnWypozycz.Name = "btnWypozycz";
            this.btnWypozycz.Size = new System.Drawing.Size(200, 43);
            this.btnWypozycz.TabIndex = 5;
            this.btnWypozycz.Text = "Wypożycz";
            this.btnWypozycz.UseVisualStyleBackColor = true;
            this.btnWypozycz.Click += new System.EventHandler(this.btnWypozycz_Click);
            // 
            // panelTabela
            // 
            this.panelTabela.Controls.Add(this.tabelaWypozyczenia);
            this.panelTabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabela.Location = new System.Drawing.Point(0, 65);
            this.panelTabela.Name = "panelTabela";
            this.panelTabela.Size = new System.Drawing.Size(776, 351);
            this.panelTabela.TabIndex = 4;
            // 
            // tabelaWypozyczenia
            // 
            this.tabelaWypozyczenia.AllowUserToAddRows = false;
            this.tabelaWypozyczenia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaWypozyczenia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaWypozyczenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaWypozyczenia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaWypozyczenia.Location = new System.Drawing.Point(0, 0);
            this.tabelaWypozyczenia.Name = "tabelaWypozyczenia";
            this.tabelaWypozyczenia.ReadOnly = true;
            this.tabelaWypozyczenia.RowHeadersVisible = false;
            this.tabelaWypozyczenia.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabelaWypozyczenia.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaWypozyczenia.RowTemplate.Height = 24;
            this.tabelaWypozyczenia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tabelaWypozyczenia.Size = new System.Drawing.Size(776, 351);
            this.tabelaWypozyczenia.TabIndex = 7;
            this.tabelaWypozyczenia.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tabelaWypozyczenia_DataBindingComplete);
            this.tabelaWypozyczenia.SelectionChanged += new System.EventHandler(this.tabelaWypozyczenia_SelectionChanged);
            // 
            // FormWypozyczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 536);
            this.Controls.Add(this.panelTabela);
            this.Controls.Add(this.panelPrzyciski);
            this.Controls.Add(this.panelFiltry);
            this.Name = "FormWypozyczenia";
            this.Text = "FormWypozyczenia";
            this.Load += new System.EventHandler(this.FormWypozyczenia_Load);
            this.panelFiltry.ResumeLayout(false);
            this.panelFiltry.PerformLayout();
            this.panelPrzyciski.ResumeLayout(false);
            this.panelPrzyciski.PerformLayout();
            this.panelTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaWypozyczenia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFiltry;
        private System.Windows.Forms.TextBox szukajTextBox;
        private System.Windows.Forms.ComboBox szukajComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Panel panelPrzyciski;
        private System.Windows.Forms.Button btnWypozycz;
        private System.Windows.Forms.Panel panelTabela;
        private System.Windows.Forms.DataGridView tabelaWypozyczenia;
        private System.Windows.Forms.TextBox sygnaturyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox wypozyczajacyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZwroc;
    }
}