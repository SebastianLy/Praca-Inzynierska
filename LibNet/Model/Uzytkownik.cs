using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Uzytkownik
    {
        [Key]
        public int ID_Uzytkownika { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(255)]
        public string Login { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(255)]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(255)]
        public string Imie { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(255)]
        public string Nazwisko { get; set; }
        [Column(TypeName = "char")]
        [MaxLength(128)]
        public string Haslo { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(7)]
        public string Rola { get; set; }
        [Column(TypeName = "bit")]
        public bool Blokada { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(255)]
        public string Powod_Blokady { get; set; }

        public int ID_Adresu { get; set; }
        public virtual Adres Adres { get; set; }

        public virtual List<Platnosc> Platnosci { get; set; }

        public virtual List<Wypozyczenie> Wypozyczenia { get; set; }

        public virtual List<Sygnatura> Sygnatury { get; set; }

        public Uzytkownik() { }

        public Uzytkownik(string login, string email, string haslo, string imie, string nazwisko, string rola)
        {
            Login = login;
            Email = email;
            Haslo = haslo;
            Imie = imie;
            Nazwisko = nazwisko;
            Rola = rola;
            Blokada = false;
        }
    }
}
