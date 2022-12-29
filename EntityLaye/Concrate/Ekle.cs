using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLaye.Concrate
{
    public class Ekle
    {
        [Key]
        public int SehirID { get; set; }
        public int PlakaKodu { get; set; }

        public string SehirAdı { get; set; }
        public int kadınokuma { get; set; }
        public int erkekokuma { get; set; }
        public int ortalamaokuma { get; set; }
        public string resim { get; set; }
        public DateTime OlusturmaDate { get; set; }
        public int AdminID { get; set; }
        public virtual Admin Admin { get; set; }

    }
}
