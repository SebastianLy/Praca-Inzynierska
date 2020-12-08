using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Model
{
    public class BibliotekaKontekst: DbContext
    {
        public BibliotekaKontekst() : base("name=BibliotekaKontekst")
        { }
        public DbSet<Uzytkownik> Uzytkownicy { get; set; }
        public DbSet<Adres> Adresy { get; set; }
        public DbSet<Platnosc> Platnosci { get; set; }
        public DbSet<Wypozyczenie> Wypozyczenia { get; set; }
        public DbSet<Sygnatura> Sygnatury { get; set; }
        public DbSet<Ksiazka> Ksiazki { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Uzytkownik>()
                .HasMany(s => s.Wypozyczenia)
                .WithOptional()
                .HasForeignKey(s => s.ID_Uzytkownika)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Wypozyczenie>()
                .HasRequired(g => g.Uzytkownik)
                .WithMany(a => a.Wypozyczenia)
                .HasForeignKey(g => g.ID_Uzytkownika);
            modelBuilder.Entity<Uzytkownik>().ToTable("Uzytkownicy");
            modelBuilder.Entity<Adres>().ToTable("Adresy");
            modelBuilder.Entity<Platnosc>().ToTable("Platnosci");
            modelBuilder.Entity<Wypozyczenie>().ToTable("Wypozyczenia");
            modelBuilder.Entity<Sygnatura>().ToTable("Sygnatury");
            modelBuilder.Entity<Ksiazka>().ToTable("Ksiazki");
        }
    }
}
