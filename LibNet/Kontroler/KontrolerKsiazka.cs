using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Model;

namespace Kontroler
{
    public class KontrolerKsiazka
    {
        public static bool SygnaturaUnikatowa(string sygnatura)
        {
            using (var db = new BibliotekaKontekst())
            {
                Sygnatura sygnatura1 = (from dbSygnatura in db.Sygnatury
                                         where dbSygnatura.ID_Sygnatura == sygnatura
                                         select dbSygnatura).FirstOrDefault();
                if (sygnatura1 != null)
                    return false;
                return true;
            }
        }

        public static bool CzyIstnieje(List<string> sygnatury)
        {
            using (var db = new BibliotekaKontekst())
            {
                foreach (var item in sygnatury)
                {
                    var sygnatura = (from dbSygnatura in db.Sygnatury
                                     where dbSygnatura.ID_Sygnatura == item
                                     select dbSygnatura).FirstOrDefault();
                    if (sygnatura == null)
                        return false;
                }
            }
            return true;
        }
        
        public static bool CzyZajete(List<string> sygnatury)
        {
            using (var db = new BibliotekaKontekst())
            {
                foreach (var item in sygnatury)
                {
                    var sygnatura = (from dbSygnatura in db.Sygnatury
                                     where dbSygnatura.ID_Sygnatura == item
                                     select dbSygnatura).FirstOrDefault();
                    if (sygnatura != null)
                    {
                        if (sygnatura.Czas_Rezerwacji != null || sygnatura.ID_Uzytkownika != null)
                            return false;
                    }
                }
            }
            return true;
        }

        public static void WypelnijTabeleKsiazek(DataTable tabela)
        {
            using (var db = new BibliotekaKontekst())
            {
                var ksiazki = (from sygnatura in db.Sygnatury
                               join ksiazka in db.Ksiazki on sygnatura.ID_Ksiazki equals ksiazka.ID_Ksiazki into gj
                               from x in gj.DefaultIfEmpty()
                               select new
                               {
                                   sygnatura.ID_Sygnatura,
                                   Tytuł = x.Tytul,
                                   Autor = x.Autor,
                                   Gatunek = x.Gatunek,
                                   Wydawca = x.Wydawca,
                                   Data_Wydania = x.Data_Wydania,
                                   Miejsce_Wydania = x.Miejsce_Wydania,
                                   Wartosc = x.Wartosc,
                                   Rezerwacja = sygnatura.Czas_Rezerwacji,
                                   Przetrzymujacy = sygnatura.ID_Uzytkownika
                               }).ToList();
                tabela.Clear();
                foreach (var ksiazka in ksiazki)
                {
                    if (ksiazka.Rezerwacja - DateTime.Now <= TimeSpan.FromMinutes(0))
                    {
                        var ksiazka1 = db.Sygnatury.Where(s => s.ID_Sygnatura == ksiazka.ID_Sygnatura).FirstOrDefault();
                        ksiazka1.Czas_Rezerwacji = null;
                        ksiazka1.ID_Uzytkownika = null;
                    }
                    tabela.Rows.Add(ksiazka.ID_Sygnatura, ksiazka.Tytuł, ksiazka.Autor, ksiazka.Gatunek, ksiazka.Wydawca + ", " + ksiazka.Miejsce_Wydania + ", " + 
                        ksiazka.Data_Wydania, ksiazka.Wartosc.ToString("#######.##"), ksiazka.Rezerwacja, ksiazka.Przetrzymujacy);
                }
            }
        }
        
        public static void DodajKsiazke(string sygnatura1, string tytul, string autor, string gatunek, string wydawca, string miejsceWydania, string dataWydania,
            decimal wartosc)
        {
            Ksiazka ksiazka = new Ksiazka(tytul, autor, gatunek, wydawca, miejsceWydania, dataWydania, wartosc);
            Sygnatura sygnatura = new Sygnatura();
            sygnatura.ID_Sygnatura = sygnatura1;
            using (var db = new BibliotekaKontekst())
            {
                var ksiazka1 = (from dbKsiazka in db.Ksiazki
                                select dbKsiazka).FirstOrDefault(dbKsiazka => dbKsiazka.Tytul == ksiazka.Tytul && dbKsiazka.Autor == ksiazka.Autor && dbKsiazka.Wydawca == ksiazka.Wydawca &&
                                dbKsiazka.Miejsce_Wydania == ksiazka.Miejsce_Wydania && dbKsiazka.Data_Wydania == ksiazka.Data_Wydania);
                if (ksiazka1 == null)
                {
                    db.Ksiazki.Add(ksiazka);
                    db.SaveChanges();
                    var ksiazka2 = (from dbKsiazka in db.Ksiazki
                                    select dbKsiazka).FirstOrDefault(dbKsiazka => dbKsiazka.Tytul == ksiazka.Tytul && dbKsiazka.Autor == ksiazka.Autor && 
                                    dbKsiazka.Wydawca == ksiazka.Wydawca && dbKsiazka.Miejsce_Wydania == ksiazka.Miejsce_Wydania && 
                                    dbKsiazka.Data_Wydania == ksiazka.Data_Wydania);
                    sygnatura.ID_Ksiazki = ksiazka2.ID_Ksiazki;
                    db.Sygnatury.Add(sygnatura);
                    db.SaveChanges();
                }
                else
                {
                    sygnatura.ID_Ksiazki = ksiazka1.ID_Ksiazki;
                    db.Sygnatury.Add(sygnatura);
                    db.SaveChanges();
                }
            }
        }

        public static void EdytujKsiazke(string sygnatura1, string tytul, string autor, string gatunek, string wydawca, string miejsceWydania, string dataWydania,
            decimal wartosc)
        {
            using (var db = new BibliotekaKontekst())
            {
                Sygnatura sygnatura = db.Sygnatury.SingleOrDefault(s => s.ID_Sygnatura == sygnatura1);
                Ksiazka ksiazka = db.Ksiazki.SingleOrDefault(k => k.ID_Ksiazki == sygnatura.ID_Ksiazki);
                ksiazka.Tytul = tytul;
                ksiazka.Autor = autor;
                ksiazka.Gatunek = gatunek;
                ksiazka.Wydawca = wydawca;
                ksiazka.Miejsce_Wydania = miejsceWydania;
                ksiazka.Data_Wydania = dataWydania;
                ksiazka.Wartosc = wartosc;
                db.SaveChanges();
            }
        }

        public static void UsunKsiazke(string sygnatura1)
        {
            using (var db = new BibliotekaKontekst())
            {
                Sygnatura sygnatura = (from dbSygnatura in db.Sygnatury select dbSygnatura).FirstOrDefault(dbSygnatura => dbSygnatura.ID_Sygnatura == sygnatura1);
                db.Sygnatury.Remove(sygnatura);
                db.SaveChanges();
            }
        }

        public static void RezerwacjaKsiazki(string sygnatura1, int id)
        {
            using (var db = new BibliotekaKontekst())
            {
                Sygnatura sygnatura = (from dbSygnatura in db.Sygnatury select dbSygnatura).FirstOrDefault(dbSygnatura => dbSygnatura.ID_Sygnatura == sygnatura1);
                sygnatura.Czas_Rezerwacji = DateTime.Now + TimeSpan.FromDays(7);
                sygnatura.ID_Uzytkownika = id;
                db.SaveChanges();
            }
        }

        public static void WyszukajKsiazke(DataTable tabela, string kolumna, string ciag)
        {
            using (var db = new BibliotekaKontekst())
            {
                var ksiazki = (from sygnatura in db.Sygnatury
                               join ksiazka in db.Ksiazki on sygnatura.ID_Ksiazki equals ksiazka.ID_Ksiazki into gj
                               from x in gj.DefaultIfEmpty()
                               select new
                               {
                                   sygnatura.ID_Sygnatura,
                                   Tytuł = x.Tytul,
                                   Autor = x.Autor,
                                   Gatunek = x.Gatunek,
                                   Wydawca = x.Wydawca,
                                   Data_Wydania = x.Data_Wydania,
                                   Miejsce_Wydania = x.Miejsce_Wydania,
                                   Wartosc = x.Wartosc,
                                   Rezerwacja = sygnatura.Czas_Rezerwacji,
                                   Przetrzymujacy = sygnatura.ID_Uzytkownika
                               }).ToList();
                tabela.Clear();
                switch (kolumna)
                {
                    case "Sygnatura":
                        foreach (var ksiazka in ksiazki)
                        {
                            if (ksiazka.ID_Sygnatura.Contains(ciag))
                            {
                                tabela.Rows.Add(ksiazka.ID_Sygnatura, ksiazka.Tytuł, ksiazka.Autor, ksiazka.Gatunek, ksiazka.Wydawca + ", " + ksiazka.Miejsce_Wydania + " " +
                                    ksiazka.Data_Wydania, ksiazka.Wartosc.ToString("#######.##"), ksiazka.Rezerwacja, ksiazka.Przetrzymujacy);
                            }
                        }
                        break;
                    case "Tytuł":
                        foreach (var ksiazka in ksiazki)
                        {
                            if (ksiazka.Tytuł.Contains(ciag))
                            {
                                tabela.Rows.Add(ksiazka.ID_Sygnatura, ksiazka.Tytuł, ksiazka.Autor, ksiazka.Gatunek, ksiazka.Wydawca + ", " + ksiazka.Miejsce_Wydania + " " +
                                    ksiazka.Data_Wydania, ksiazka.Wartosc.ToString("#######.##"), ksiazka.Rezerwacja, ksiazka.Przetrzymujacy);
                            }
                        }
                        break;
                    case "Autor":
                        foreach (var ksiazka in ksiazki)
                        {
                            if (ksiazka.Autor.Contains(ciag))
                            {
                                tabela.Rows.Add(ksiazka.ID_Sygnatura, ksiazka.Tytuł, ksiazka.Autor, ksiazka.Gatunek, ksiazka.Wydawca + ", " + ksiazka.Miejsce_Wydania + " " +
                                    ksiazka.Data_Wydania, ksiazka.Wartosc.ToString("#######.##"), ksiazka.Rezerwacja, ksiazka.Przetrzymujacy);
                            }
                        }
                        break;
                    case "Gatunek":
                        foreach (var ksiazka in ksiazki)
                        {
                            if (ksiazka.Gatunek.Contains(ciag))
                            {
                                tabela.Rows.Add(ksiazka.ID_Sygnatura, ksiazka.Tytuł, ksiazka.Autor, ksiazka.Gatunek, ksiazka.Wydawca + ", " + ksiazka.Miejsce_Wydania + " " +
                                    ksiazka.Data_Wydania, ksiazka.Wartosc.ToString("#######.##"), ksiazka.Rezerwacja, ksiazka.Przetrzymujacy);
                            }
                        }
                        break;
                    case "Wydanie":
                        foreach (var ksiazka in ksiazki)
                        {
                            if (ksiazka.Wydawca.Contains(ciag) || ksiazka.Miejsce_Wydania.Contains(ciag) || ksiazka.Data_Wydania.Contains(ciag))
                            {
                                tabela.Rows.Add(ksiazka.ID_Sygnatura, ksiazka.Tytuł, ksiazka.Autor, ksiazka.Gatunek, ksiazka.Wydawca + ", " + ksiazka.Miejsce_Wydania + " " +
                                    ksiazka.Data_Wydania, ksiazka.Wartosc.ToString("#######.##"), ksiazka.Rezerwacja, ksiazka.Przetrzymujacy);
                            }
                        }
                        break;
                    case "Przetrzymujący":
                        foreach (var ksiazka in ksiazki)
                        {
                            if (ksiazka.Przetrzymujacy.ToString().Contains(ciag))
                            {
                                tabela.Rows.Add(ksiazka.ID_Sygnatura, ksiazka.Tytuł, ksiazka.Autor, ksiazka.Gatunek, ksiazka.Wydawca + ", " + ksiazka.Miejsce_Wydania + " " +
                                    ksiazka.Data_Wydania, ksiazka.Wartosc.ToString("#######.##"), ksiazka.Rezerwacja, ksiazka.Przetrzymujacy);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public static void AktualizujUstawieniaBiblioteki(string nazwa, string adres, string telefon, string email, string poniedzialek, string wtorek, string sroda, 
            string czwartek, string piatek, string sobota, string niedziela, int rezerwacje, int limit, decimal oplata)
        {
            string[] tekst = {nazwa, adres, telefon, email, poniedzialek, wtorek, sroda, czwartek, piatek, sobota, niedziela, rezerwacje.ToString(),
                limit.ToString(), oplata.ToString()};
            //File.WriteAllLines("Ustawienia.txt", tekst);
            File.WriteAllLines("Ustawienia1.txt", tekst);
            File.Replace("Ustawienia1.txt", "Ustawienia.txt", "Backup.txt");
            File.Delete("Backup.txt");
        }

        public static string[] WyswietlUstawienia()
        {
            string[] ustawienia = File.ReadAllLines("Ustawienia.txt");
            return ustawienia;
        }
    }
}
