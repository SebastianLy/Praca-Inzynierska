﻿
namespace Widok
{
    partial class FormPlatnosci
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
            this.tabelaPlatnosci = new System.Windows.Forms.DataGridView();
            this.panelPrzyciski = new System.Windows.Forms.Panel();
            this.btnDodajPlatnosc = new System.Windows.Forms.Button();
            this.kwotaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uzytkownikTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFiltry.SuspendLayout();
            this.panelTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPlatnosci)).BeginInit();
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
            this.panelFiltry.Size = new System.Drawing.Size(776, 65);
            this.panelFiltry.TabIndex = 3;
            // 
            // szukajTextBox
            // 
            this.szukajTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szukajTextBox.Location = new System.Drawing.Point(304, 21);
            this.szukajTextBox.Name = "szukajTextBox";
            this.szukajTextBox.Size = new System.Drawing.Size(140, 24);
            this.szukajTextBox.TabIndex = 3;
            // 
            // szukajComboBox
            // 
            this.szukajComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.szukajComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.szukajComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.szukajComboBox.Items.AddRange(new object[] {
            "Imię/Nazwisko",
            "Adres"});
            this.szukajComboBox.Location = new System.Drawing.Point(145, 21);
            this.szukajComboBox.Name = "szukajComboBox";
            this.szukajComboBox.Size = new System.Drawing.Size(140, 24);
            this.szukajComboBox.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(16, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(113, 24);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Wyszukaj w:";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(459, 11);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(164, 43);
            this.btnSzukaj.TabIndex = 0;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // panelTabela
            // 
            this.panelTabela.Controls.Add(this.tabelaPlatnosci);
            this.panelTabela.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabela.Location = new System.Drawing.Point(0, 65);
            this.panelTabela.Name = "panelTabela";
            this.panelTabela.Size = new System.Drawing.Size(776, 350);
            this.panelTabela.TabIndex = 4;
            // 
            // tabelaPlatnosci
            // 
            this.tabelaPlatnosci.AllowUserToAddRows = false;
            this.tabelaPlatnosci.AllowUserToDeleteRows = false;
            this.tabelaPlatnosci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaPlatnosci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaPlatnosci.Location = new System.Drawing.Point(0, 0);
            this.tabelaPlatnosci.Name = "tabelaPlatnosci";
            this.tabelaPlatnosci.ReadOnly = true;
            this.tabelaPlatnosci.RowHeadersVisible = false;
            this.tabelaPlatnosci.RowHeadersWidth = 51;
            this.tabelaPlatnosci.RowTemplate.Height = 24;
            this.tabelaPlatnosci.Size = new System.Drawing.Size(776, 350);
            this.tabelaPlatnosci.TabIndex = 1;
            // 
            // panelPrzyciski
            // 
            this.panelPrzyciski.Controls.Add(this.btnDodajPlatnosc);
            this.panelPrzyciski.Controls.Add(this.kwotaTextBox);
            this.panelPrzyciski.Controls.Add(this.label3);
            this.panelPrzyciski.Controls.Add(this.opisTextBox);
            this.panelPrzyciski.Controls.Add(this.label2);
            this.panelPrzyciski.Controls.Add(this.uzytkownikTextBox);
            this.panelPrzyciski.Controls.Add(this.label1);
            this.panelPrzyciski.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrzyciski.Location = new System.Drawing.Point(0, 415);
            this.panelPrzyciski.Name = "panelPrzyciski";
            this.panelPrzyciski.Size = new System.Drawing.Size(776, 121);
            this.panelPrzyciski.TabIndex = 5;
            // 
            // btnDodajPlatnosc
            // 
            this.btnDodajPlatnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajPlatnosc.Location = new System.Drawing.Point(338, 52);
            this.btnDodajPlatnosc.Name = "btnDodajPlatnosc";
            this.btnDodajPlatnosc.Size = new System.Drawing.Size(164, 43);
            this.btnDodajPlatnosc.TabIndex = 6;
            this.btnDodajPlatnosc.Text = "Zatwierdź płatność";
            this.btnDodajPlatnosc.UseVisualStyleBackColor = true;
            this.btnDodajPlatnosc.Click += new System.EventHandler(this.btnDodajPlatnosc_Click);
            // 
            // kwotaTextBox
            // 
            this.kwotaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kwotaTextBox.Location = new System.Drawing.Point(391, 14);
            this.kwotaTextBox.Name = "kwotaTextBox";
            this.kwotaTextBox.Size = new System.Drawing.Size(135, 24);
            this.kwotaTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(309, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kwota:";
            // 
            // opisTextBox
            // 
            this.opisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisTextBox.Location = new System.Drawing.Point(150, 52);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(135, 52);
            this.opisTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis zapłaty:";
            // 
            // uzytkownikTextBox
            // 
            this.uzytkownikTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uzytkownikTextBox.Location = new System.Drawing.Point(150, 14);
            this.uzytkownikTextBox.Name = "uzytkownikTextBox";
            this.uzytkownikTextBox.Size = new System.Drawing.Size(135, 24);
            this.uzytkownikTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Płacący:";
            // 
            // FormPlatnosci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 536);
            this.Controls.Add(this.panelPrzyciski);
            this.Controls.Add(this.panelTabela);
            this.Controls.Add(this.panelFiltry);
            this.Name = "FormPlatnosci";
            this.Text = "FormPlatnosci";
            this.Load += new System.EventHandler(this.FormPlatnosci_Load);
            this.panelFiltry.ResumeLayout(false);
            this.panelFiltry.PerformLayout();
            this.panelTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPlatnosci)).EndInit();
            this.panelPrzyciski.ResumeLayout(false);
            this.panelPrzyciski.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFiltry;
        private System.Windows.Forms.TextBox szukajTextBox;
        private System.Windows.Forms.ComboBox szukajComboBox;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Panel panelTabela;
        private System.Windows.Forms.DataGridView tabelaPlatnosci;
        private System.Windows.Forms.Panel panelPrzyciski;
        private System.Windows.Forms.TextBox kwotaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uzytkownikTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajPlatnosc;
    }
}