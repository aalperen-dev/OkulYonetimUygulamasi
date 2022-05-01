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
    public class Ogrenci
    {
        public Adres Adresi = new Adres();
        public List<string> Kitaplar = new List<string>();
        public List<DersNotu> Notlar = new List<DersNotu>();

        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public SUBE Sube { get; set; }
        public CINSIYET Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double Ortalama
        {
            get
            {
                return (Notlar.Count == 0) ? 0 : Notlar.Average(a => a.DersOrtalama);
            }
        }

        public Ogrenci()
        {
        }

        public Ogrenci(int no, string ad, string soyad, DateTime dogumTarihi, CINSIYET cinsiyet, SUBE sube)
        {
            No = no;
            Ad = ad;
            Soyad = soyad;
            Sube = sube;
            Cinsiyet = cinsiyet;
            DogumTarihi = dogumTarihi;
        }
    }

    public enum SUBE
    {
        Empty, A, B, C
    }

    public enum CINSIYET
    {
        Empty, Kiz, Erkek
    }

}
