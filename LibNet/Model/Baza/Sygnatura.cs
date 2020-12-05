using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Sygnatura
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(63)]
        public string ID_Sygnatura { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Czas_Rezerwacji { get; set; }

        [Column("Aktualny_Posiadacz")]
        public int? ID_Uzytkownika { get; set; }
        public virtual Uzytkownik Uzytkownik { get; set; }

        public int ID_Ksiazki { get; set; }
        public virtual Ksiazka Ksiazka { get; set; }

        public virtual List<Wypozyczenie> Wypozyczenia { get; set; }
    }
}
