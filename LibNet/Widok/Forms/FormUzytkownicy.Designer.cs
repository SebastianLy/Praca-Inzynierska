
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabelaUzytkownicy = new System.Windows.Forms.DataGridView();
            this.panelFiltry = new System.Windows.Forms.Panel();
            this.szukajTextBox = new System.Windows.Forms.TextBox();
            this.szukajComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.panelTabela = new System.Windows.Forms.Panel();
            this.panelPrzyciski = new System.Windows.Forms.Panel();
            this.powodTextBox = new System.Windows.Forms.TextBox();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnBlokada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaUzytkownicy)).BeginInit();
            this.panelFiltry.SuspendLayout();
            this.panelTabela.SuspendLayout();
            this.panelPrzyciski.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelaUzytkownicy
            // 
            this.tabelaUzytkownicy.AllowUserToAddRows = false;
            this.tabelaUzytkownicy.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaUzytkownicy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaUzytkownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaUzytkownicy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaUzytkownicy.Location = new System.Drawing.Point(0, 0);
            this.tabelaUzytkownicy.Name = "tabelaUzytkownicy";
            this.tabelaUzytkownicy.ReadOnly = true;
            this.tabelaUzytkownicy.RowHeadersVisible = false;
            this.tabelaUzytkownicy.RowHeadersWidth = 51;
            this.tabelaUzytkownicy.RowTemplate.Height = 24;
            this.tabelaUzytkownicy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tabelaUzytkownicy.Size = new System.Drawing.Size(776, 471);
            this.tabelaUzytkownicy.TabIndex = 0;
            this.tabelaUzytkownicy.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tabelaUzytkownicy_DataBindingComplete);
            this.tabelaUzytkownicy.SelectionChanged += new System.EventHandler(this.tabelaUzytkownicy_SelectionChanged);
            // 
            // panelFiltry
            // 
            this.panelFiltry.Controls.Add(this.szukajTextBox);
            this.panelFiltry.Controls.Add(this.szukajComboBox);
            this.panelFiltry.Controls.Add(this.label1);
            this.panelFiltry.Controls.Add(this.btnSzukaj);
            this.panelFiltry.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltry.Location = new System.Drawing.Point(0, 0);
            this.panelFiltry.Name = "panelFiltry";
            this.panelFiltry.Size = new System.Drawing.Size(776, 65);
            this.panelFiltry.TabIndex = 1;
            // 
            // szukajTextBox
            // 
            this.szukajTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szukajTextBox.Location = new System.Drawing.Point(302, 19);
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
            "ID",
            "Email",
            "Imię/Nazwisko",
            "Adres"});
            this.szukajComboBox.Location = new System.Drawing.Point(143, 19);
            this.szukajComboBox.Name = "szukajComboBox";
            this.szukajComboBox.Size = new System.Drawing.Size(140, 24);
            this.szukajComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wyszukaj w:";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukaj.Location = new System.Drawing.Point(461, 11);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(164, 43);
            this.btnSzukaj.TabIndex = 0;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // panelTabela
            // 
            this.panelTabela.Controls.Add(this.tabelaUzytkownicy);
            this.panelTabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabela.Location = new System.Drawing.Point(0, 65);
            this.panelTabela.Name = "panelTabela";
            this.panelTabela.Size = new System.Drawing.Size(776, 471);
            this.panelTabela.TabIndex = 2;
            // 
            // panelPrzyciski
            // 
            this.panelPrzyciski.Controls.Add(this.powodTextBox);
            this.panelPrzyciski.Controls.Add(this.btnUsun);
            this.panelPrzyciski.Controls.Add(this.btnBlokada);
            this.panelPrzyciski.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPrzyciski.Location = new System.Drawing.Point(0, 467);
            this.panelPrzyciski.Name = "panelPrzyciski";
            this.panelPrzyciski.Size = new System.Drawing.Size(776, 69);
            this.panelPrzyciski.TabIndex = 3;
            // 
            // powodTextBox
            // 
            this.powodTextBox.Location = new System.Drawing.Point(13, 14);
            this.powodTextBox.Multiline = true;
            this.powodTextBox.Name = "powodTextBox";
            this.powodTextBox.Size = new System.Drawing.Size(208, 43);
            this.powodTextBox.TabIndex = 2;
            // 
            // btnUsun
            // 
            this.btnUsun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsun.Enabled = false;
            this.btnUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.Location = new System.Drawing.Point(600, 14);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(164, 43);
            this.btnUsun.TabIndex = 1;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnBlokada
            // 
            this.btnBlokada.Enabled = false;
            this.btnBlokada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBlokada.Location = new System.Drawing.Point(242, 14);
            this.btnBlokada.Name = "btnBlokada";
            this.btnBlokada.Size = new System.Drawing.Size(200, 43);
            this.btnBlokada.TabIndex = 0;
            this.btnBlokada.Text = "Zablokuj/Odblokuj";
            this.btnBlokada.UseVisualStyleBackColor = true;
            this.btnBlokada.Click += new System.EventHandler(this.btnBlokada_Click);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnBlokada;
        private System.Windows.Forms.TextBox powodTextBox;
    }
}