using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Adres
    {
        [Key]
        public int ID_Adresu { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(255)]
        public string Miejscowosc { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(255)]
        public string Ulica { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string Nr_Domu { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string Nr_Mieszkania { get; set; }
        [Column(TypeName = "char")]
        [MaxLength(5)]
        public string Kod_Pocztowy { get; set; }

        public virtual List<Uzytkownik> Uzytkownicy { get; set; }

        public Adres(string miejscowosc, string ulica, string numerDomu, string numerMieszkania, string kodPocztowy)
        {
            Miejscowosc = miejscowosc;
            Ulica = ulica;
            Nr_Domu = numerDomu;
            Nr_Mieszkania = numerMieszkania;
            Kod_Pocztowy = kodPocztowy;
        }
    }
}
