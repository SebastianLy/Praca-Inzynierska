using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Kontroler
{
    public class KontrolerKsiazka
    {
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
                    tabela.Rows.Add(ksiazka.ID_Sygnatura, ksiazka.Tytuł, ksiazka.Autor, ksiazka.Gatunek, ksiazka.Wydawca + ", " + ksiazka.Miejsce_Wydania + ", " + 
                        ksiazka.Data_Wydania, ksiazka.Wartosc, ksiazka.Rezerwacja, ksiazka.Przetrzymujacy);
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
    }
}
