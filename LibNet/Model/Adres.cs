using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    class Adres
    {
        public int ID_Adresu { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Miejscowosc { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Ulica { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Nr_Domu { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Nr_Mieszkania { get; set; }
        [Column(TypeName = "varchar(6)")]
        public string Kod_Pocztowy { get; set; }

        public virtual List<Uzytkownik> Uzytkownicy { get; set; }
    }
}
