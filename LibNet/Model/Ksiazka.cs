using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    class Ksiazka
    {
        public int ID_Ksiazki { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Tytul { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Autor { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Gatunek { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Wydawca { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Data_Wydania { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Miejsce_Wydania { get; set; }
        [Column(TypeName = "smallmoney")]
        public string Wartosc { get; set; }

        public virtual List<Sygnatura> Sygnatury { get; set; }
    }
}
