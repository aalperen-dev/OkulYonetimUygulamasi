using System;
//  -ÖDEVİ HAZIRLAYANLAR-
//      Ayşenur Aydın
//     Alperen Alperen
//       Cüneyt Kaya
//   Mehmet Kadir Deniz
namespace Ogrenci
{
    public class Adres
    {
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }
        public Adres(string il, string ilce, string mahalle)
        {
            this.Il = il;
            this.Ilce = ilce;
            this.Mahalle = mahalle;
        }

        public Adres()
        {
            this.Il = " ";
            this.Ilce = " ";
            this.Mahalle = " ";
        }
    }
}
