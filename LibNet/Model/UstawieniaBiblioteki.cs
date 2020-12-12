using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UstawieniaBiblioteki
    {
        string Nazwa;
        string Adres;
        string Telefon;
        string Email;
        string OtwarcieP;
        string OtwarcieW;
        string OtwarcieS;
        string OtwarcieC;
        string OtwarcieP2;
        string OtwarcieS2;
        string OtwarcieN;
        int Wypozyczenia;
        int Limit;
        decimal Kara;

        public UstawieniaBiblioteki()
        {
            Nazwa = "Biblioteka";
            Wypozyczenia = 21;
            Limit = 5;
            Kara = 3;
        }

        public UstawieniaBiblioteki(string nazwa, string adres, string telefon, string email, string poniedzialek, string wtorek, string sroda,
            string czwartek, string piatek, string sobota, string niedziela, int wypozyczenia, int limit, decimal oplata)
        {
            Nazwa = nazwa;
            Adres = adres;
            Telefon = telefon;
            Email = email;
            OtwarcieP = poniedzialek;
            OtwarcieW = wtorek;
            OtwarcieS = sroda;
            OtwarcieC = czwartek;
            OtwarcieP2 = piatek;
            OtwarcieS2 = sobota;
            OtwarcieN = niedziela;
            Wypozyczenia = wypozyczenia;
            Limit = limit;
            Kara = oplata;
        }
    }
}
