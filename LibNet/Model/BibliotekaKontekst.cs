using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Model
{
    class BibliotekaKontekst: DbContext
    {
        public DbSet<Uzytkownik> Uzytkownicy { get; set; }
        public DbSet<Adres> Adresy { get; set; }
        public DbSet<Platnosc> Platnosci { get; set; }
        public DbSet<Wypozyczenie> Wypozyczenia { get; set; }
        public DbSet<Sygnatura> Sygnatury { get; set; }
        public DbSet<Ksiazka> Ksiazki { get; set; }
    }
}
