using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                db.Adresy.Add(adres);
                uzytkownik.ID_Adresu = adres.ID_Adresu;
                db.Uzytkownicy.Add(uzytkownik);
                db.SaveChanges();
            }
        }
        static string SzyfrowanieHasla(string haslo)
        {
            byte[] hasloTablica = Encoding.Unicode.GetBytes(haslo);
            System.Security.Cryptography.HashAlgorithm hashAlgo = new System.Security.Cryptography.SHA512Managed();
            byte[] hash = hashAlgo.ComputeHash(hasloTablica);
            return Encoding.Unicode.GetString(hash);
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
                        uzytkownik.Powod_Blokady, uzytkownik.Miejscowosc + " " + uzytkownik.Ulica + " " + uzytkownik.NRDomu + " " +
                        uzytkownik.NRMieszkania + " " + uzytkownik.KodPocztowy);
                }
            }
        }

        public static void Wyszukaj(DataTable tabela, string szukaj, string kolumna)
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
                            if (uzytkownik.ID_Uzytkownika.ToString().Contains(szukaj))
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
                            if (uzytkownik.Email.ToString().Contains(szukaj))
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
                            if (uzytkownik.Imie.ToString().Contains(szukaj) || uzytkownik.Nazwisko.ToString().Contains(szukaj))
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
                            if (uzytkownik.Miejscowosc.ToString().Contains(szukaj) || uzytkownik.Ulica.ToString().Contains(szukaj) ||
                                uzytkownik.NRDomu.ToString().Contains(szukaj) || uzytkownik.NRMieszkania.ToString().Contains(szukaj) ||
                                uzytkownik.KodPocztowy.ToString().Contains(szukaj))
                            {
                                tabela.Rows.Add(uzytkownik.ID_Uzytkownika, uzytkownik.Email, uzytkownik.Imie + " " + uzytkownik.Nazwisko, uzytkownik.Rola, 
                                    uzytkownik.Blokada, uzytkownik.Powod_Blokady, uzytkownik.Miejscowosc + " " + uzytkownik.Ulica + " " + uzytkownik.NRDomu + " " + 
                                    uzytkownik.NRMieszkania + " " + uzytkownik.KodPocztowy.ToString().Substring(0,2) + "-" + 
                                    uzytkownik.KodPocztowy.ToString().Substring(2,3));
                            }
                        }
                        break;
                    default:
                        foreach (var uzytkownik in uzytkownicy)
                        {
                            tabela.Rows.Add(uzytkownik.ID_Uzytkownika, uzytkownik.Email, uzytkownik.Imie + " " + uzytkownik.Nazwisko, uzytkownik.Rola, 
                                uzytkownik.Blokada, uzytkownik.Powod_Blokady, uzytkownik.Miejscowosc + " " + uzytkownik.Ulica + " " + uzytkownik.NRDomu + " " + 
                                uzytkownik.NRMieszkania + " " + uzytkownik.KodPocztowy);
                        }
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
                    uzytkownik.Blokada = false;
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
                db.Uzytkownicy.Remove(uzytkownik);
                db.SaveChanges();
            }
        }
    }
}
