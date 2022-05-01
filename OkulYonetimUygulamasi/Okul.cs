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
    public class Okul
    {
        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        public Okul()
        {
            SahteVeriGir();
        }

        public void OgrenciEkle(int no, string ad, string soyad, DateTime dogumTarihi, CINSIYET cinsiyet, SUBE sube)
        {
            Ogrenci a = new Ogrenci(no, ad, soyad, dogumTarihi, cinsiyet, sube);
            Ogrenciler.Add(a);
        }

        public void OgrenciSil(int no)
        {
            Ogrenci o = Ogrenciler.Where(a => a.No == no).FirstOrDefault();
            Ogrenciler.Remove(o);
        }

        public void NotEkle(int no, string ders, int not)
        {
            Ogrenci o = Ogrenciler.Where(a => a.No == no).FirstOrDefault();
            DersNotu dn = new DersNotu(ders, not);
            o.Notlar.Add(dn);
        }

        public void AdresEkle(int no, string il, string ilce, string mahalle)
        {
            Ogrenci o = Ogrenciler.Where(a => a.No == no).FirstOrDefault();
            Adres adr = new Adres(il, ilce, mahalle);
            o.Adresi = (adr);
        }
        public void KitapEkle(int no, string kitapismi)
        {
            Ogrenci o = Ogrenciler.Where(a => a.No == no).FirstOrDefault();
            o.Kitaplar.Add(kitapismi);
        }

        public List<Ogrenci> ListeGor(int sayi, SUBE sube, CINSIYET cinsiyet, DateTime dogumTarihi)
        {
            List<Ogrenci> liste = this.Ogrenciler;
            //"1-Bütün Öğrencileri Listele
            if (sayi == 2)//2-Şubeye Göre Öğrencileri Listele "
            {
                liste = this.Ogrenciler.Where(a => a.Sube == sube).ToList();
            }
            else if (sayi == 3)//3-Cinsiyetine Göre Ögrencileri Listel
            {
                liste = this.Ogrenciler.Where(a => a.Cinsiyet == cinsiyet).ToList();
            }
            else if (sayi == 4)//4-Dogum Tarihine Göre Ögrencileri Listel
            {
                liste = this.Ogrenciler.Where(a => a.DogumTarihi >= dogumTarihi).ToList();
            }
            else if (sayi == 8)  //8-Okuldaki en basarılı 5 ögrenciyi listele "
            {
                liste = this.Ogrenciler.OrderByDescending(a => a.Ortalama).Take(5).ToList();
            }
            else if (sayi == 9)//9-Okuldaki en basarısız 3 ögrenciyi listele "
            {
                liste = this.Ogrenciler.OrderBy(a => a.Ortalama).Take(3).ToList();
            }
            else if (sayi == 10) //10-Subedeki en basarılı 5 ögrenciyi listele "
            {
                liste = this.Ogrenciler.Where(a => a.Sube == sube).OrderByDescending(a => a.Ortalama).Take(5).ToList();
            }
            else if (sayi == 11)  //11 Subedeki en basarısız 3 ögrenciyi listele "
            {
                liste = this.Ogrenciler.Where(a => a.Sube == sube).OrderBy(a => a.Ortalama).Take(3).ToList();
            }
            return liste;

        }

        public double SubeOrtalamasıhesapla(SUBE sube)
        {
            return this.Ogrenciler.Where(a => a.Sube == sube).Average(a => a.Ortalama);
        }

        public void SahteVeriGir()
        {
            OgrenciEkle(20, "Aydın", "Kaya", new DateTime(2009, 7, 9), CINSIYET.Erkek, SUBE.A);
            OgrenciEkle(65, "Burak", "Şimşek", new DateTime(2010, 2, 20), CINSIYET.Erkek, SUBE.C);
            OgrenciEkle(21, "Aysenur", "Aydın", new DateTime(2011, 3, 11), CINSIYET.Kiz, SUBE.B);
            OgrenciEkle(66, "Beyza", "Yavuz", new DateTime(2008, 12, 24), CINSIYET.Kiz, SUBE.A);
            OgrenciEkle(22, "Adnan", "Çil", new DateTime(2009, 2, 4), CINSIYET.Erkek, SUBE.B);
            OgrenciEkle(67, "Büşra", "Çeçmeci", new DateTime(2009, 6, 7), CINSIYET.Kiz, SUBE.C);
            OgrenciEkle(23, "Ali", "Kurt", new DateTime(2010, 7, 8), CINSIYET.Erkek, SUBE.A);
            OgrenciEkle(68, "Veli", "Güçlü", new DateTime(2011, 5, 3), CINSIYET.Erkek, SUBE.C);
            OgrenciEkle(24, "Tuğçe", "Sert", new DateTime(2007, 4, 25), CINSIYET.Kiz, SUBE.A);
            OgrenciEkle(69, "Cengiz", "Yıldız", new DateTime(2008, 3, 19), CINSIYET.Erkek, SUBE.B);
        }
    }
}