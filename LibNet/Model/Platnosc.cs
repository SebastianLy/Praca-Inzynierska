﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Platnosc
    {
        [Key]
        public int ID_Platnosci { get; set; }
        [Column(TypeName = "smallmoney")]
        public decimal Kwota { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime Data_Zaplaty { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(255)]
        public string Opis_Zaplaty { get; set; }

        [Column("Placacy")]
        public int ID_Uzytkownika { get; set; }
        public virtual Uzytkownik Uzytkownik { get; set; }

        public Platnosc(decimal kwota, DateTime dataZaplaty, string opisZaplaty, int IDUzytkownika)
        {
            Kwota = kwota;
            Data_Zaplaty = dataZaplaty;
            Opis_Zaplaty = opisZaplaty;
            ID_Uzytkownika = IDUzytkownika;
        }
    }
}
