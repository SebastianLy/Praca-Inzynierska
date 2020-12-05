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
        public DateTime Data_Zwrotu { get; set; }
        [Column(TypeName = "bit")]
        public bool Czy_Zwrocone { get; set; }

        [Column("Czytelnik")]
        public int ID_Uzytkownika { get; set; }
        public virtual Uzytkownik Uzytkownik { get; set; }

        public virtual List<Sygnatura> Sygnatury { get; set; }
    }
}
