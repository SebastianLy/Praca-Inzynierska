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

        public virtual List<Sygnatura> Sygnatury { get; set; }

        public Wypozyczenie(DateTime data, List<Sygnatura> sygnatury, int uzytkownik)
        {
            Data_Wypozyczenia = data;
            Sygnatury = sygnatury;
            ID_Uzytkownika = uzytkownik;
        }
    }
}
