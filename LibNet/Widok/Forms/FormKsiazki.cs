using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kontroler;

namespace Widok
{
    public partial class FormKsiazki : Form
    {
        DataTable tabela = new DataTable("Książki");
        public FormKsiazki()
        {
            InitializeComponent();
        }

        private void FormKsiazki_Load(object sender, EventArgs e)
        {
            tabela.Columns.Add("Sygnatura", typeof(string));
            tabela.Columns.Add("Tytuł", typeof(string));
            tabela.Columns.Add("Autor", typeof(string));
            tabela.Columns.Add("Gatunek", typeof(string));
            tabela.Columns.Add("Wydanie", typeof(string));
            tabela.Columns.Add("Wartość", typeof(decimal));
            tabela.Columns.Add("Rezerwacja", typeof(DateTime));
            tabela.Columns.Add("Przetrzymujący", typeof(int));
            KontrolerKsiazka.WypelnijTabeleKsiazek(tabela);
            tabelaKsiazki.DataSource = tabela;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormDodajKsiazke form = new FormDodajKsiazke();
            form.ShowDialog();
        }

        private void tabelaKsiazki_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormDodajKsiazke form = new FormDodajKsiazke(
                    tabelaKsiazki.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    tabelaKsiazki.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    tabelaKsiazki.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    tabelaKsiazki.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    tabelaKsiazki.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    tabelaKsiazki.Rows[e.RowIndex].Cells[5].Value.ToString());
                form.ShowDialog();
            }
            catch (NullReferenceException) { }
            catch (InvalidCastException) { }
        }
    }
}
