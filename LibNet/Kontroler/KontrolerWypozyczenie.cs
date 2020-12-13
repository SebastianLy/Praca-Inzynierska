using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Kontroler
{
    public class KontrolerWypozyczenie
    {
        public static void WyswietlWypozyczenia(DataTable tabela, int id)
        {
            tabela.Clear();
            using (var db = new BibliotekaKontekst())
            {
                if (id == 0)
                {
                    var wypozyczenia = (from wypozyczenie in db.Wypozyczenia
                                        join sygnatura in db.Sygnatury on wypozyczenie.ID_Sygnatura equals sygnatura.ID_Sygnatura into gj
                                        from x in gj.DefaultIfEmpty()
                                        join ksiazka in db.Ksiazki on x.ID_Ksiazki equals ksiazka.ID_Ksiazki into an
                                        from a in an.DefaultIfEmpty()
                                        select new
                                        {
                                            ID = wypozyczenie.ID_Wypozyczenia,
                                            DataWypozyczenia = wypozyczenie.Data_Wypozyczenia,
                                            DataZwrotu = wypozyczenie.Data_Zwrotu,
                                            Wypozyczajacy = wypozyczenie.ID_Uzytkownika,
                                            IDSygnatura = x.ID_Sygnatura,
                                            Ksiazka = a.Tytul
                                        }).ToList();
                    foreach (var wypozyczenie in wypozyczenia)
                    {
                        tabela.Rows.Add(wypozyczenie.ID, wypozyczenie.DataWypozyczenia, wypozyczenie.DataZwrotu, wypozyczenie.Wypozyczajacy,
                            wypozyczenie.IDSygnatura, wypozyczenie.Ksiazka);
                    }
                }
                else
                {
                    var wypozyczenia = (from wypozyczenie in db.Wypozyczenia
                                        where wypozyczenie.ID_Uzytkownika == id
                                        join sygnatura in db.Sygnatury on wypozyczenie.ID_Sygnatura equals sygnatura.ID_Sygnatura into gj
                                        from x in gj.DefaultIfEmpty()
                                        join ksiazka in db.Ksiazki on x.ID_Ksiazki equals ksiazka.ID_Ksiazki into an
                                        from a in an.DefaultIfEmpty()
                                        select new
                                        {
                                            ID = wypozyczenie.ID_Wypozyczenia,
                                            DataWypozyczenia = wypozyczenie.Data_Wypozyczenia,
                                            DataZwrotu = wypozyczenie.Data_Zwrotu,
                                            Wypozyczajacy = wypozyczenie.ID_Uzytkownika,
                                            IDSygnatura = x.ID_Sygnatura,
                                            Ksiazka = a.Tytul
                                        }).ToList();
                    foreach (var wypozyczenie in wypozyczenia)
                    {
                        tabela.Rows.Add(wypozyczenie.ID, wypozyczenie.DataWypozyczenia, wypozyczenie.DataZwrotu,
                            wypozyczenie.IDSygnatura, wypozyczenie.Ksiazka);
                    }
                }
            }
        }

        public static void Wypozycz(List<string> sygnatury, int uzytkownik)
        {
            using (var db = new BibliotekaKontekst())
            {
                List<Sygnatura> sygnatura = db.Sygnatury.Where(syg => sygnatury.Any(s1 => s1 == syg.ID_Sygnatura)).ToList();
                
                Uzytkownik u = db.Uzytkownicy.Where(user => user.ID_Uzytkownika == uzytkownik).FirstOrDefault();
                
                foreach (var item in sygnatura)
                {
                    item.ID_Uzytkownika = u.ID_Uzytkownika;
                    Wypozyczenie w1 = new Wypozyczenie(DateTime.Now, item.ID_Sygnatura, u.ID_Uzytkownika);
                    db.Wypozyczenia.Add(w1);
                }
                db.SaveChanges();
            }
        }

        public static void Zwroc(string idSygnatury, int idWypozyczenia)
        {
            using (var db = new BibliotekaKontekst())
            {
                Sygnatura sygnatura = db.Sygnatury.Where(s => s.ID_Sygnatura == idSygnatury).FirstOrDefault();
                sygnatura.ID_Uzytkownika = null;
                Wypozyczenie wypozyczenie = db.Wypozyczenia.Where(w => w.ID_Wypozyczenia == idWypozyczenia).FirstOrDefault();
                wypozyczenie.Data_Zwrotu = DateTime.Now;
                db.SaveChanges();
            }
        }

        public static void AutomatycznaBlokada(int dni)
        {
            using (var db = new BibliotekaKontekst())
            {
                var wypozyczenia = (from wypozyczenie in db.Wypozyczenia
                                    join sygnatura in db.Sygnatury on wypozyczenie.ID_Sygnatura equals sygnatura.ID_Sygnatura into gj
                                    from x in gj.DefaultIfEmpty()
                                    join ksiazka in db.Ksiazki on x.ID_Ksiazki equals ksiazka.ID_Ksiazki into an
                                    from a in an.DefaultIfEmpty()
                                    select new
                                    {
                                        ID = wypozyczenie.ID_Wypozyczenia,
                                        DataWypozyczenia = wypozyczenie.Data_Wypozyczenia,
                                        DataZwrotu = wypozyczenie.Data_Zwrotu,
                                        Wypozyczajacy = wypozyczenie.ID_Uzytkownika,
                                        IDSygnatura = x.ID_Sygnatura,
                                        Ksiazka = a.Tytul
                                    }).ToList();
                foreach (var wypozyczenie in wypozyczenia)
                {
                    if (DateTime.Now - wypozyczenie.DataWypozyczenia > TimeSpan.FromDays(dni))
                    {
                        var uzytkownik = (from uzytkownicy in db.Uzytkownicy
                                          where uzytkownicy.ID_Uzytkownika == wypozyczenie.Wypozyczajacy
                                          select uzytkownicy).FirstOrDefault();
                        uzytkownik.Blokada = true;
                        if (uzytkownik.Powod_Blokady == "")
                            uzytkownik.Powod_Blokady = "Nie oddanie książki w terminie: " + wypozyczenie.IDSygnatura;
                        else
                            uzytkownik.Powod_Blokady += ", " + wypozyczenie.IDSygnatura;
                    }
                }
            }
        }

        public static void WyszukajWypozyczenia(DataTable tabela, string kolumna, string ciag, int id)
        {
            using (var db = new BibliotekaKontekst())
            {
                if (id == 0)
                {
                    var wypozyczenia = (from wypozyczenie in db.Wypozyczenia
                                        join sygnatura in db.Sygnatury on wypozyczenie.ID_Sygnatura equals sygnatura.ID_Sygnatura into gj
                                        from x in gj.DefaultIfEmpty()
                                        join ksiazka in db.Ksiazki on x.ID_Ksiazki equals ksiazka.ID_Ksiazki into an
                                        from a in an.DefaultIfEmpty()
                                        select new
                                        {
                                            ID = wypozyczenie.ID_Wypozyczenia,
                                            DataWypozyczenia = wypozyczenie.Data_Wypozyczenia,
                                            DataZwrotu = wypozyczenie.Data_Zwrotu,
                                            Wypozyczajacy = wypozyczenie.ID_Uzytkownika,
                                            IDSygnatura = x.ID_Sygnatura,
                                            Ksiazka = a.Tytul
                                        }).ToList();
                    tabela.Clear();
                    switch (kolumna)
                    {
                        case "ID Wypożyczenia":
                            foreach (var wypozyczenie in wypozyczenia)
                            {
                                if (wypozyczenie.ID.ToString().Contains(ciag))
                                {
                                    tabela.Rows.Add(wypozyczenie.ID, wypozyczenie.DataWypozyczenia, wypozyczenie.DataZwrotu, wypozyczenie.Wypozyczajacy,
                                        wypozyczenie.IDSygnatura, wypozyczenie.Ksiazka);
                                }
                            }
                            break;
                        case "Data Wypożyczenia":
                            foreach (var wypozyczenie in wypozyczenia)
                            {
                                if (wypozyczenie.DataWypozyczenia.ToString().Contains(ciag))
                                {
                                    tabela.Rows.Add(wypozyczenie.ID, wypozyczenie.DataWypozyczenia, wypozyczenie.DataZwrotu, wypozyczenie.Wypozyczajacy,
                                        wypozyczenie.IDSygnatura, wypozyczenie.Ksiazka);
                                }
                            }
                            break;
                        case "Data Zwrotu":
                            foreach (var wypozyczenie in wypozyczenia)
                            {
                                if (wypozyczenie.DataZwrotu.ToString().Contains(ciag))
                                {
                                    tabela.Rows.Add(wypozyczenie.ID, wypozyczenie.DataWypozyczenia, wypozyczenie.DataZwrotu, wypozyczenie.Wypozyczajacy,
                                        wypozyczenie.IDSygnatura, wypozyczenie.Ksiazka);
                                }
                            }
                            break;
                        case "Wypożyczający":
                            foreach (var wypozyczenie in wypozyczenia)
                            {
                                if (wypozyczenie.Wypozyczajacy.ToString().Contains(ciag))
                                {
                                    tabela.Rows.Add(wypozyczenie.ID, wypozyczenie.DataWypozyczenia, wypozyczenie.DataZwrotu, wypozyczenie.Wypozyczajacy,
                                        wypozyczenie.IDSygnatura, wypozyczenie.Ksiazka);
                                }
                            }
                            break;
                        case "Sygnatura":
                            foreach (var wypozyczenie in wypozyczenia)
                            {
                                if (wypozyczenie.IDSygnatura.Contains(ciag))
                                {
                                    tabela.Rows.Add(wypozyczenie.ID, wypozyczenie.DataWypozyczenia, wypozyczenie.DataZwrotu, wypozyczenie.Wypozyczajacy,
                                        wypozyczenie.IDSygnatura, wypozyczenie.Ksiazka);
                                }
                            }
                            break;
                        case "Tytuł":
                            foreach (var wypozyczenie in wypozyczenia)
                            {
                                if (wypozyczenie.Ksiazka.Contains(ciag))
                                {
                                    tabela.Rows.Add(wypozyczenie.ID, wypozyczenie.DataWypozyczenia, wypozyczenie.DataZwrotu, wypozyczenie.Wypozyczajacy,
                                        wypozyczenie.IDSygnatura, wypozyczenie.Ksiazka);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    var wypozyczenia = (from wypozyczenie in db.Wypozyczenia
                                        where wypozyczenie.ID_Uzytkownika == id
                                        join sygnatura in db.Sygnatury on wypozyczenie.ID_Sygnatura equals sygnatura.ID_Sygnatura into gj
                                        from x in gj.DefaultIfEmpty()
                                        join ksiazka in db.Ksiazki on x.ID_Ksiazki equals ksiazka.ID_Ksiazki into an
                                        from a in an.DefaultIfEmpty()
                                        select new
                                        {
                                            ID = wypozyczenie.ID_Wypozyczenia,
                                            DataWypozyczenia = wypozyczenie.Data_Wypozyczenia,
                                            DataZwrotu = wypozyczenie.Data_Zwrotu,
                                            Wypozyczajacy = wypozyczenie.ID_Uzytkownika,
                                            IDSygnatura = x.ID_Sygnatura,
                                            Ksiazka = a.Tytul
                                        }).ToList();
                    tabela.Clear();
                    switch (kolumna)
                    {
                        case "ID Wypożyczenia":
                            foreach (var wypozyczenie in wypozyczenia)
                            {
                                if (wypozyczenie.ID.ToString().Contains(ciag))
                                {
                                    tabela.Rows.Add(wypozyczenie.ID, wypozyczenie.DataWypozyczenia, wypozyczenie.DataZwrotu,
                                        wypozyczenie.IDSygnatura, wypozyczenie.Ksiazka);
                                }
                            }
                            break;
                        case "Data Wypożyczenia":
                            foreach (var wypozyczenie in wypozyczenia)
                            {
                                if (wypozyczenie.DataWypozyczenia.ToString().Contains(ciag))
                                {
                                    tabela.Rows.Add(wypozyczenie.ID, wypozyczenie.DataWypozyczenia, wypozyczenie.DataZwrotu,
                                        wypozyczenie.IDSygnatura, wypozyczenie.Ksiazka);
                                }
                            }
                            break;
                        case "Data Zwrotu":
                            foreach (var wypozyczenie in wypozyczenia)
                            {
                                if (wypozyczenie.DataZwrotu.ToString().Contains(ciag))
                                {
                                    tabela.Rows.Add(wypozyczenie.ID, wypozyczenie.DataWypozyczenia, wypozyczenie.DataZwrotu,
                                        wypozyczenie.IDSygnatura, wypozyczenie.Ksiazka);
                                }
                            }
                            break;
                        case "Sygnatura":
                            foreach (var wypozyczenie in wypozyczenia)
                            {
                                if (wypozyczenie.IDSygnatura.Contains(ciag))
                                {
                                    tabela.Rows.Add(wypozyczenie.ID, wypozyczenie.DataWypozyczenia, wypozyczenie.DataZwrotu,
                                        wypozyczenie.IDSygnatura, wypozyczenie.Ksiazka);
                                }
                            }
                            break;
                        case "Tytuł":
                            foreach (var wypozyczenie in wypozyczenia)
                            {
                                if (wypozyczenie.Ksiazka.Contains(ciag))
                                {
                                    tabela.Rows.Add(wypozyczenie.ID, wypozyczenie.DataWypozyczenia, wypozyczenie.DataZwrotu,
                                        wypozyczenie.IDSygnatura, wypozyczenie.Ksiazka);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
