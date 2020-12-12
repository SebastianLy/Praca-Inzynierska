using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Wypozyczenie
    {
        [Key]
        public int ID_Wypozyczenia { get; set; }
        [Column(TypeName = "date")]
        public DateTime Data_Wypozyczenia { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Data_Zwrotu { get; set; }
        [Column(TypeName = "bit")]
        public bool Czy_Zwrocone { get; set; }

        public int ID_Uzytkownika { get; set; }
        public virtual Uzytkownik Uzytkownik { get; set; }

        public string ID_Sygnatura { get; set; }
        public virtual Sygnatura Sygnatura { get; set; }

        public Wypozyczenie() { }

        public Wypozyczenie(DateTime dataWypozyczenia, string sygnatura, int uzytkownik)
        {
            Data_Wypozyczenia = dataWypozyczenia;
            ID_Sygnatura = sygnatura;
            ID_Uzytkownika = uzytkownik;
        }
    }
}
