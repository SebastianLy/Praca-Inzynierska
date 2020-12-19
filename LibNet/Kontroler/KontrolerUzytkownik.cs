using System;
using System.Linq;
using System.Text;
using System.Data;
using Model;

namespace Kontroler
{
    public static class KontrolerUzytkownik
    {
        public static bool Logowanie(string login, string haslo)
        {
            string zaszyfrowaneHaslo = SzyfrowanieHasla(haslo);
            using (var db = new BibliotekaKontekst())
            {
                Uzytkownik uzytkownik = (from dbUzytkownik in db.Uzytkownicy 
                                         where dbUzytkownik.Login == login && dbUzytkownik.Haslo == zaszyfrowaneHaslo 
                                         select dbUzytkownik).FirstOrDefault();
                if (uzytkownik != null)
                    return true;
                return false;
            }
        }

        public static string ZnajdzImie(string login)
        {
            using (var db = new BibliotekaKontekst())
            {
                Uzytkownik uzytkownik = (from dbUzytkownik in db.Uzytkownicy
                                         where dbUzytkownik.Login == login
                                         select dbUzytkownik).FirstOrDefault();
                if (uzytkownik != null)
                    return uzytkownik.Imie;
            }
            return "";
        }

        public static bool CzyZablokowane(int id)
        {
            using (var db = new BibliotekaKontekst())
            {
                Uzytkownik uzytkownik = (from dbUzytkownik in db.Uzytkownicy
                                         where dbUzytkownik.ID_Uzytkownika == id
                                         select dbUzytkownik).FirstOrDefault();
                if (uzytkownik.Blokada)
                    return true;
                return false;
            }
        }

        public static string PowodBlokady(int id)
        {
            using (var db = new BibliotekaKontekst())
            {
                Uzytkownik uzytkownik = (from dbUzytkownik in db.Uzytkownicy
                                         where dbUzytkownik.ID_Uzytkownika == id
                                         select dbUzytkownik).FirstOrDefault();
                if (uzytkownik.Blokada)
                    return uzytkownik.Powod_Blokady;
                return "";
            }
        }

        public static bool CzyIstnieje(int id)
        {
            using (var db = new BibliotekaKontekst())
            {
                Uzytkownik uzytkownik = (from dbUzytkownik in db.Uzytkownicy
                                         where dbUzytkownik.ID_Uzytkownika == id
                                         select dbUzytkownik).FirstOrDefault();
                if (uzytkownik == null)
                    return false;
                return true;
            }
        }

        public static bool LoginUnikatowy(string login)
        {
            using (var db = new BibliotekaKontekst())
            {
                Uzytkownik uzytkownik = (from dbUzytkownik in db.Uzytkownicy
                                         where dbUzytkownik.Login == login
                                         select dbUzytkownik).FirstOrDefault();
                if (uzytkownik != null)
                    return false;
                return true;
            }
        }

        public static bool EmailUnikatowy(string email)
        {
            using (var db = new BibliotekaKontekst())
            {
                Uzytkownik uzytkownik = (from dbUzytkownik in db.Uzytkownicy
                                         where dbUzytkownik.Email == email
                                         select dbUzytkownik).FirstOrDefault();
                if (uzytkownik != null)
                    return false;
                return true;
            }
        }

        public static void Rejestracja(string login, string email, string haslo, string imie, string nazwisko, string miejscowosc,
            string ulica, string numerDomu, string numerMieszkania, string kodPocztowy)
        {
            Uzytkownik uzytkownik = new Uzytkownik(login, email, SzyfrowanieHasla(haslo), imie, nazwisko, "User");
            Adres adres = new Adres(miejscowosc, ulica, numerDomu, numerMieszkania, kodPocztowy);
            using (var db = new BibliotekaKontekst())
            {
                int count = (from user in db.Uzytkownicy select user).Count();
                if (count == 0)
                    uzytkownik.Rola = "Admin";
                uzytkownik.Powod_Blokady = "";
                db.Adresy.Add(adres);
                uzytkownik.ID_Adresu = adres.ID_Adresu;
                db.Uzytkownicy.Add(uzytkownik);
                db.SaveChanges();
            }
        }

        static string SzyfrowanieHasla(string haslo)
        {
            var bajty = Encoding.UTF8.GetBytes(haslo);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedBajty = hash.ComputeHash(bajty);
                return BitConverter.ToString(hashedBajty).Replace("-", "");
            }
        }

        public static void WypelnijTabeleUzytkownikow(DataTable tabela)
        {
            using (var db = new BibliotekaKontekst())
            {
                var uzytkownicy = (from uzytkownik in db.Uzytkownicy
                                   join adres in db.Adresy on uzytkownik.ID_Adresu equals adres.ID_Adresu
                                   select new
                                   {
                                       ID_Uzytkownika = uzytkownik.ID_Uzytkownika,
                                       Email = uzytkownik.Email,
                                       Imie = uzytkownik.Imie,
                                       Nazwisko = uzytkownik.Nazwisko,
                                       Rola = uzytkownik.Rola,
                                       Blokada = uzytkownik.Blokada,
                                       Powod_Blokady = uzytkownik.Powod_Blokady,
                                       Miejscowosc = adres.Miejscowosc,
                                       Ulica = adres.Ulica,
                                       KodPocztowy = adres.Kod_Pocztowy,
                                       NRDomu = adres.Nr_Domu,
                                       NRMieszkania = adres.Nr_Mieszkania
                                   }).ToList();
                tabela.Clear();
                foreach (var uzytkownik in uzytkownicy)
                {
                    tabela.Rows.Add(uzytkownik.ID_Uzytkownika, uzytkownik.Email, uzytkownik.Imie + " " + uzytkownik.Nazwisko, uzytkownik.Rola, uzytkownik.Blokada,
                        uzytkownik.Powod_Blokady, uzytkownik.Miejscowosc + ", " + uzytkownik.Ulica + " " + uzytkownik.NRDomu + " " +
                        uzytkownik.NRMieszkania + " " + uzytkownik.KodPocztowy.Substring(0, 2) + "-" + uzytkownik.KodPocztowy.Substring(2, 3));
                }
            }
        }

        public static void WyszukajUzytkownikow(DataTable tabela, string kolumna, string ciag)
        {          
            using (var db = new BibliotekaKontekst())
            {
                var uzytkownicy = (from uzytkownik in db.Uzytkownicy
                                   join adres in db.Adresy on uzytkownik.ID_Adresu equals adres.ID_Adresu
                                   select new
                                   {
                                       ID_Uzytkownika = uzytkownik.ID_Uzytkownika,
                                       Email = uzytkownik.Email,
                                       Imie = uzytkownik.Imie,
                                       Nazwisko = uzytkownik.Nazwisko,
                                       Rola = uzytkownik.Rola,
                                       Blokada = uzytkownik.Blokada,
                                       Powod_Blokady = uzytkownik.Powod_Blokady,
                                       Miejscowosc = adres.Miejscowosc,
                                       Ulica = adres.Ulica,
                                       KodPocztowy = adres.Kod_Pocztowy,
                                       NRDomu = adres.Nr_Domu,
                                       NRMieszkania = adres.Nr_Mieszkania
                                   }).ToList();
                tabela.Clear();
                switch (kolumna)
                {
                    case "ID":
                        foreach (var uzytkownik in uzytkownicy)
                        {
                            if (uzytkownik.ID_Uzytkownika.ToString().Contains(ciag))
                            {
                                tabela.Rows.Add(uzytkownik.ID_Uzytkownika, uzytkownik.Email, uzytkownik.Imie + " " + uzytkownik.Nazwisko, uzytkownik.Rola, 
                                    uzytkownik.Blokada, uzytkownik.Powod_Blokady, uzytkownik.Miejscowosc + " " + uzytkownik.Ulica + " " + uzytkownik.NRDomu + " " + 
                                    uzytkownik.NRMieszkania + " " + uzytkownik.KodPocztowy);
                            }
                        }
                        break;
                    case "Email":
                        foreach (var uzytkownik in uzytkownicy)
                        {
                            if (uzytkownik.Email.ToString().Contains(ciag))
                            {
                                tabela.Rows.Add(uzytkownik.ID_Uzytkownika, uzytkownik.Email, uzytkownik.Imie + " " + uzytkownik.Nazwisko, uzytkownik.Rola, 
                                    uzytkownik.Blokada, uzytkownik.Powod_Blokady, uzytkownik.Miejscowosc + " " + uzytkownik.Ulica + " " + uzytkownik.NRDomu + " " + 
                                    uzytkownik.NRMieszkania + " " + uzytkownik.KodPocztowy);
                            }
                        }
                        break;
                    case "Imię/Nazwisko":
                        foreach (var uzytkownik in uzytkownicy)
                        {
                            if (uzytkownik.Imie.ToString().Contains(ciag) || uzytkownik.Nazwisko.ToString().Contains(ciag))
                            {
                                tabela.Rows.Add(uzytkownik.ID_Uzytkownika, uzytkownik.Email, uzytkownik.Imie + " " + uzytkownik.Nazwisko, uzytkownik.Rola,
                                    uzytkownik.Blokada, uzytkownik.Powod_Blokady, uzytkownik.Miejscowosc + " " + uzytkownik.Ulica + " " + uzytkownik.NRDomu + " " +
                                    uzytkownik.NRMieszkania + " " + uzytkownik.KodPocztowy);
                            }
                        }
                        break;
                    case "Powód Blokady":
                        foreach (var uzytkownik in uzytkownicy)
                        {
                            if (uzytkownik.Powod_Blokady.Contains(ciag))
                            {
                                tabela.Rows.Add(uzytkownik.ID_Uzytkownika, uzytkownik.Email, uzytkownik.Imie + " " + uzytkownik.Nazwisko, uzytkownik.Rola,
                                    uzytkownik.Blokada, uzytkownik.Powod_Blokady, uzytkownik.Miejscowosc + " " + uzytkownik.Ulica + " " + uzytkownik.NRDomu + " " +
                                    uzytkownik.NRMieszkania + " " + uzytkownik.KodPocztowy);
                            }
                        }
                        break;
                    case "Adres":
                        foreach (var uzytkownik in uzytkownicy)
                        {
                            if (uzytkownik.Miejscowosc.ToString().Contains(ciag) || uzytkownik.Ulica.ToString().Contains(ciag) ||
                                uzytkownik.NRDomu.ToString().Contains(ciag) || uzytkownik.NRMieszkania.ToString().Contains(ciag) ||
                                uzytkownik.KodPocztowy.ToString().Contains(ciag))
                            {
                                tabela.Rows.Add(uzytkownik.ID_Uzytkownika, uzytkownik.Email, uzytkownik.Imie + " " + uzytkownik.Nazwisko, uzytkownik.Rola, 
                                    uzytkownik.Blokada, uzytkownik.Powod_Blokady, uzytkownik.Miejscowosc + " " + uzytkownik.Ulica + " " + uzytkownik.NRDomu + " " + 
                                    uzytkownik.NRMieszkania + " " + uzytkownik.KodPocztowy.ToString().Substring(0,2) + "-" + 
                                    uzytkownik.KodPocztowy.ToString().Substring(2,3));
                            }
                        }
                        break;
                    default:
                        break;
                }      
            }
        }

        public static void Blokada(int id , string powod)
        {
            using (var db = new BibliotekaKontekst())
            {
                var uzytkownik = (from dbUzytkownik in db.Uzytkownicy
                                  where dbUzytkownik.ID_Uzytkownika == id
                                  select dbUzytkownik).FirstOrDefault();
                if (uzytkownik.Blokada)
                {
                    uzytkownik.Blokada = false;
                    uzytkownik.Powod_Blokady = "";
                }
                else
                {
                    uzytkownik.Blokada = true;
                    uzytkownik.Powod_Blokady = powod;
                }
                db.SaveChanges();
            }
        }

        public static void Usun(int id)
        {
            using (var db = new BibliotekaKontekst())
            {
                var uzytkownik = (from dbUzytkownik in db.Uzytkownicy
                                  where dbUzytkownik.ID_Uzytkownika == id
                                  select dbUzytkownik).FirstOrDefault();
                var ksiazka = (from dbKsiazka in db.Sygnatury
                               where dbKsiazka.ID_Uzytkownika == id
                               select dbKsiazka).FirstOrDefault();
                if (ksiazka != null)
                {
                    ksiazka.Czas_Rezerwacji = null;
                    ksiazka.ID_Uzytkownika = null;
                }
                db.Uzytkownicy.Remove(uzytkownik);
                db.SaveChanges();
            }
        }

        public static void Awans (int id)
        {
            using (var db = new BibliotekaKontekst())
            {
                var uzytkownik = (from dbUzytkownik in db.Uzytkownicy
                                  where dbUzytkownik.ID_Uzytkownika == id
                                  select dbUzytkownik).FirstOrDefault();
                if (uzytkownik.Rola == "Admin")
                    uzytkownik.Rola = "User";
                else
                    uzytkownik.Rola = "Admin";
                db.SaveChanges();
            }
        }

        public static void WyswietlPlatnosci(DataTable tabela, int id)
        {
            using (var db = new BibliotekaKontekst())
            {
                if (id == 0)
                {
                    var platnosci = (from platnosc in db.Platnosci
                                     join uzytkownik in db.Uzytkownicy on platnosc.ID_Uzytkownika equals uzytkownik.ID_Uzytkownika into gj
                                     from x in gj.DefaultIfEmpty()
                                     select new
                                     {
                                         platnosc.ID_Platnosci,
                                         x.ID_Uzytkownika,
                                         PlacacyImie = x.Imie,
                                         PlacacyNazwisko = x.Nazwisko,
                                         platnosc.Data_Zaplaty,
                                         platnosc.Kwota,
                                         platnosc.Opis_Zaplaty
                                     }).ToList();
                    tabela.Clear();
                    foreach (var platnosc in platnosci)
                    {
                        tabela.Rows.Add(platnosc.ID_Platnosci, platnosc.ID_Uzytkownika, platnosc.PlacacyImie + " " + platnosc.PlacacyNazwisko, platnosc.Data_Zaplaty,
                            platnosc.Kwota.ToString("#######.##"), platnosc.Opis_Zaplaty);
                    }
                }
                else
                {
                    var platnosci = (from platnosc in db.Platnosci
                                     where platnosc.ID_Uzytkownika == id
                                     join uzytkownik in db.Uzytkownicy on platnosc.ID_Uzytkownika equals uzytkownik.ID_Uzytkownika into gj
                                     from x in gj.DefaultIfEmpty()
                                     select new
                                     {
                                         platnosc.ID_Platnosci,
                                         x.ID_Uzytkownika,
                                         PlacacyImie = x.Imie,
                                         PlacacyNazwisko = x.Nazwisko,
                                         platnosc.Data_Zaplaty,
                                         platnosc.Kwota,
                                         platnosc.Opis_Zaplaty
                                     }).ToList();
                    tabela.Clear();
                    foreach (var platnosc in platnosci)
                    {
                        tabela.Rows.Add(platnosc.ID_Platnosci, platnosc.PlacacyImie + " " + platnosc.PlacacyNazwisko, platnosc.Data_Zaplaty,
                            platnosc.Kwota.ToString("#######.##"), platnosc.Opis_Zaplaty);
                    }
                }
            }
        }

        public static void DodajPlatnosc(int idUzytkownika, string opisZaplaty, decimal kwota)
        {
            using (var db = new BibliotekaKontekst())
            {
                Platnosc platnosc = new Platnosc(kwota, DateTime.Now, opisZaplaty, idUzytkownika);
                db.Platnosci.Add(platnosc);
                db.SaveChanges();
            }
        }

        public static void WyszukajPlatnosci(DataTable tabela, string kolumna, string ciag, int id)
        {
            using (var db = new BibliotekaKontekst())
            {
                if (id == 0)
                {
                    var platnosci = (from platnosc in db.Platnosci
                                     join uzytkownik in db.Uzytkownicy on platnosc.ID_Uzytkownika equals uzytkownik.ID_Uzytkownika into gj
                                     from x in gj.DefaultIfEmpty()
                                     select new
                                     {
                                         platnosc.ID_Platnosci,
                                         x.ID_Uzytkownika,
                                         PlacacyImie = x.Imie,
                                         PlacacyNazwisko = x.Nazwisko,
                                         platnosc.Data_Zaplaty,
                                         platnosc.Kwota,
                                         platnosc.Opis_Zaplaty
                                     }).ToList();
                    tabela.Clear();
                    switch (kolumna)
                    {
                        case "ID Płatności":
                            foreach (var platnosc in platnosci)
                            {
                                if (platnosc.ID_Platnosci.ToString().Contains(ciag))
                                {
                                    tabela.Rows.Add(platnosc.ID_Platnosci, platnosc.ID_Uzytkownika, platnosc.PlacacyImie + " " + platnosc.PlacacyNazwisko, platnosc.Data_Zaplaty,
                                        platnosc.Kwota.ToString("#######.##"), platnosc.Opis_Zaplaty);
                                }
                            }
                            break;
                        case "ID Płacącego":
                            foreach (var platnosc in platnosci)
                            {
                                if (platnosc.ID_Uzytkownika.ToString().Contains(ciag))
                                {
                                    tabela.Rows.Add(platnosc.ID_Platnosci, platnosc.ID_Uzytkownika, platnosc.PlacacyImie + " " + platnosc.PlacacyNazwisko, platnosc.Data_Zaplaty,
                                        platnosc.Kwota.ToString("#######.##"), platnosc.Opis_Zaplaty);
                                }
                            }
                            break;
                        case "Imię/Nazwisko":
                            foreach (var platnosc in platnosci)
                            {
                                if (platnosc.PlacacyImie.Contains(ciag) || platnosc.PlacacyNazwisko.Contains(ciag))
                                {
                                    tabela.Rows.Add(platnosc.ID_Platnosci, platnosc.ID_Uzytkownika, platnosc.PlacacyImie + " " + platnosc.PlacacyNazwisko, platnosc.Data_Zaplaty,
                                        platnosc.Kwota.ToString("#######.##"), platnosc.Opis_Zaplaty);
                                }
                            }
                            break;
                        case "Data Zapłaty":
                            foreach (var platnosc in platnosci)
                            {
                                if (platnosc.Data_Zaplaty.ToString().Contains(ciag))
                                {
                                    tabela.Rows.Add(platnosc.ID_Platnosci, platnosc.ID_Uzytkownika, platnosc.PlacacyImie + " " + platnosc.PlacacyNazwisko, platnosc.Data_Zaplaty,
                                        platnosc.Kwota.ToString("#######.##"), platnosc.Opis_Zaplaty);
                                }
                            }
                            break;
                        case "Opis Zapłaty":
                            foreach (var platnosc in platnosci)
                            {
                                if (platnosc.Opis_Zaplaty.Contains(ciag))
                                {
                                    tabela.Rows.Add(platnosc.ID_Platnosci, platnosc.ID_Uzytkownika, platnosc.PlacacyImie + " " + platnosc.PlacacyNazwisko, platnosc.Data_Zaplaty,
                                        platnosc.Kwota.ToString("#######.##"), platnosc.Opis_Zaplaty);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    var platnosci = (from platnosc in db.Platnosci
                                     where platnosc.ID_Uzytkownika == id
                                     join uzytkownik in db.Uzytkownicy on platnosc.ID_Uzytkownika equals uzytkownik.ID_Uzytkownika into gj
                                     from x in gj.DefaultIfEmpty()
                                     select new
                                     {
                                         platnosc.ID_Platnosci,
                                         x.ID_Uzytkownika,
                                         PlacacyImie = x.Imie,
                                         PlacacyNazwisko = x.Nazwisko,
                                         platnosc.Data_Zaplaty,
                                         platnosc.Kwota,
                                         platnosc.Opis_Zaplaty
                                     }).ToList();
                    tabela.Clear();
                    switch (kolumna)
                    {
                        case "ID Płatności":
                            foreach (var platnosc in platnosci)
                            {
                                if (platnosc.ID_Platnosci.ToString().Contains(ciag))
                                {
                                    tabela.Rows.Add(platnosc.ID_Platnosci, platnosc.PlacacyImie + " " + platnosc.PlacacyNazwisko, platnosc.Data_Zaplaty,
                                        platnosc.Kwota.ToString("#######.##"), platnosc.Opis_Zaplaty);
                                }
                            }
                            break;
                        case "Imię/Nazwisko":
                            foreach (var platnosc in platnosci)
                            {
                                if (platnosc.PlacacyImie.Contains(ciag) || platnosc.PlacacyNazwisko.Contains(ciag))
                                {
                                    tabela.Rows.Add(platnosc.ID_Platnosci, platnosc.PlacacyImie + " " + platnosc.PlacacyNazwisko, platnosc.Data_Zaplaty,
                                        platnosc.Kwota.ToString("#######.##"), platnosc.Opis_Zaplaty);
                                }
                            }
                            break;
                        case "Data Zapłaty":
                            foreach (var platnosc in platnosci)
                            {
                                if (platnosc.Data_Zaplaty.ToString().Contains(ciag))
                                {
                                    tabela.Rows.Add(platnosc.ID_Platnosci, platnosc.PlacacyImie + " " + platnosc.PlacacyNazwisko, platnosc.Data_Zaplaty,
                                        platnosc.Kwota.ToString("#######.##"), platnosc.Opis_Zaplaty);
                                }
                            }
                            break;
                        case "Opis Zapłaty":
                            foreach (var platnosc in platnosci)
                            {
                                if (platnosc.Opis_Zaplaty.Contains(ciag))
                                {
                                    tabela.Rows.Add(platnosc.ID_Platnosci, platnosc.PlacacyImie + " " + platnosc.PlacacyNazwisko, platnosc.Data_Zaplaty,
                                        platnosc.Kwota.ToString("#######.##"), platnosc.Opis_Zaplaty);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public static int IDRola(string login)
        {
            using (var db = new BibliotekaKontekst())
            {
                Uzytkownik uzytkownik = db.Uzytkownicy.Where(u => u.Login == login).FirstOrDefault();
                if (uzytkownik.Rola == "Admin")
                {
                    return 0;
                }
                return uzytkownik.ID_Uzytkownika;
            }
        }
    }
}
