using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    class Platnosc
    {
        public int ID_Platnosci { get; set; }
        [Column(TypeName = "smallmoney")]
        public decimal Kwota { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime Data_Zaplaty { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Opis_Zaplaty { get; set; }

        [Column("Placacy")]
        public int ID_Uzytkownika { get; set; }
        public virtual Uzytkownik Uzytkownik { get; set; }
    }
}
