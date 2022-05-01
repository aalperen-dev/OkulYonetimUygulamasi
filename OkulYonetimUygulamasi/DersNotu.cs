using System;
using System.Collections.Generic;
using System.Linq;
//  -ÖDEVİ HAZIRLAYANLAR-
//      Ayşenur Aydın
//     Alperen Alperen
//       Cüneyt Kaya
//   Mehmet Kadir Deniz
namespace Ogrenci
{
    public class DersNotu
    {
        public string DersAdi { get; set; }
        public int Not { get; set; }

        public double DersOrtalama
        {
            get
            {
                return (dersinnotlari.Count == 0) ? 0 : this.dersinnotlari.Average();
            }
        }

        public List<int> dersinnotlari = new List<int>();

        public DersNotu()
        {
        }

        public DersNotu(string dersAdi, int not)
        {
            this.DersAdi = dersAdi;
            this.Not = not;
            dersinnotlari.Add(not);
        }
    }
}
