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
        public static void WyswietlWypozyczenia(DataTable tabela)
        {
            using (var db = new BibliotekaKontekst())
            {
                var query = db.Wypozyczenia
                    .Select(wypozyczenie => new
                    {
                        ID = wypozyczenie.ID_Wypozyczenia,
                        DataWypozyczenia = wypozyczenie.Data_Wypozyczenia,
                        DataZwrotu = wypozyczenie.Data_Zwrotu,
                        Wypozyczajacy = wypozyczenie.ID_Uzytkownika,
                        Ksiazki = wypozyczenie.Sygnatury
                        .Select(sygnatura => new
                        {
                            ID = sygnatura.ID_Sygnatura,
                            Ksiazka = sygnatura.ID_Ksiazki
                        })
                        .ToList()
                    }).ToList();
                foreach (var item in query)
                {
                    foreach (var item1 in item.Ksiazki)
                    {
                        tabela.Rows.Add(item.ID, item.DataWypozyczenia, item.DataZwrotu, item.Wypozyczajacy, item1.ID);
                    }                   
                }
    //            var experiments = myDbContext.Experiments
    //.Where(experiment => ...)              // only if you don't want all experiments
    //.Select(experiment => new
    //{   // Select only the properties you actually plan to use
    //    Id = experiment.Id,
    //    Name = experiment.Name,
    //    ...

    //    // get all or some of its ExperimentTypes
    //    ExperimentTypes = experiment.ExperimentTypes
    //         .Where(experimentType => ...)  // only if you don't want all experiment types
    //         .Select(experimentType => new
    //         {
    //             // again: select only the properties you plan to use
    //             Id = experimentType.Id,
    //             ...
    //         })
    //         .ToList(),
    //});
            }
        }

        public static void Wypozycz(List<string> sygnatury, int uzytkownik)
        {
            using (var db = new BibliotekaKontekst())
            {
                List<Sygnatura> sygnatura = db.Sygnatury.Where(syg => sygnatury.Any(s1 => s1 == syg.ID_Sygnatura)).ToList();
                Wypozyczenie w1 = new Wypozyczenie(DateTime.Now, sygnatura, uzytkownik);
                Uzytkownik u = db.Uzytkownicy.Where(user => user.ID_Uzytkownika == uzytkownik).FirstOrDefault();
                db.Wypozyczenia.Add(w1);
                foreach (var item in sygnatura)
                {
                    item.ID_Uzytkownika = u.ID_Uzytkownika;
                }
                db.SaveChanges();
            }
        }

        public static void Zwroc(int id)
        {
            using (var db = new BibliotekaKontekst())
            {
                Wypozyczenie wypozyczenie = db.Wypozyczenia.Where(w => w.ID_Wypozyczenia == id).FirstOrDefault();
                wypozyczenie.Data_Zwrotu = DateTime.Now;
                List<Sygnatura> sygnatury = wypozyczenie.Sygnatury;
                foreach (Sygnatura sygnatura in sygnatury)
                {
                    sygnatura.ID_Uzytkownika = null;
                }
                db.SaveChanges();
            }
        }
    }
}
