using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    class Uzytkownik
    {
        public int ID_Uzytkownika { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Login { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Imie { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Nazwisko { get; set; }
        [Column(TypeName = "char(128)")]
        public string Haslo { get; set; }
        [Column(TypeName = "varchar(5)")]
        public string Rola { get; set; }

        public int ID_Adres { get; set; }
        public virtual Adres Adres { get; set; }

        public virtual List<Platnosc> Platnosci { get; set; }

        public virtual List<Wypozyczenie> Wypozyczenia { get; set; }

        public virtual List<Sygnatura> Sygnatury { get; set; }
    }
}
