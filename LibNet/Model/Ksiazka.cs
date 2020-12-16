using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Ksiazka
    {
        [Key]
        public int ID_Ksiazki { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(255)]
        public string Tytul { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(255)]
        public string Autor { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(255)]
        public string Gatunek { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(255)]
        public string Wydawca { get; set; }
        [Column(TypeName = "char")]
        [MaxLength(4)]
        public string Data_Wydania { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(255)]
        public string Miejsce_Wydania { get; set; }
        [Column(TypeName = "smallmoney")]
        public decimal Wartosc { get; set; }

        public virtual List<Sygnatura> Sygnatury { get; set; }

        public Ksiazka() { }

        public Ksiazka(string tytul, string autor, string gatunek, string wydawca, string miejsceWydania, string dataWydania, decimal wartosc)
        {
            Tytul = tytul;
            Autor = autor;
            Gatunek = gatunek;
            Wydawca = wydawca;
            Data_Wydania = dataWydania;
            Miejsce_Wydania = miejsceWydania;
            Wartosc = wartosc;
        }
    }
}
