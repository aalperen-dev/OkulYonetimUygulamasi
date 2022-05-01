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
    public class Uygulama
    {
        static public Okul okl = new Okul();
        public void Calistir()
        {
            Menu();
            while (true)
            {
                string secim = AracGerecler.SecimAl();
                Console.WriteLine();
                switch (secim)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "8":
                    case "9":
                    case "10":
                    case "11":
                        Listele(int.Parse(secim));
                        break;
                    case "5":
                        IlListele();
                        break;
                    case "6":
                        NotListele();
                        break;
                    case "7":
                        KitapListele();
                        break;
                    case "12":
                        OgrenciOrtalama();
                        break;
                    case "13":
                        SubeOrtalama();
                        break;
                    case "14":
                        SonKitap();
                        break;
                    case "15":
                        OgrenciEkle();
                        break;
                    case "16":
                        OgrenciGuncelle();
                        break;
                    case "17":
                        OgrenciSil();
                        break;
                    case "18":
                        AdresGir();
                        break;
                    case "19":
                        KitapGir();
                        break;
                    case "20":
                        NotGir();
                        break;
                    case "liste":
                        Menu();
                        break;
                    case "çıkış":
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Menüyü tekrar listelemek için “liste“, çıkıs yapmak için “çıkış” yazın.");
                Console.WriteLine();
            }
        }
        public void Menu()
        {
            Console.WriteLine("------  Okul Yönetim Uygulaması  ----- ");
            Console.WriteLine("1 - Bütün öğrencileri listele");
            Console.WriteLine("2 - Şubeye göre öğrencileri listele");
            Console.WriteLine("3 - Cinsiyetine göre öğrencileri listele");
            Console.WriteLine("4 - Şu tarihten sonra doğan öğrencileri listele");
            Console.WriteLine("5 - İlere göre sıralayarak öğrencileri listele");
            Console.WriteLine("6 - Öğrencinin tüm notlarını listele (Derse göre sıralanıp listelenecek");
            Console.WriteLine("7 - Öğrencinin okuduğu kitapları listele");
            Console.WriteLine("8 - Okuldaki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("9 - Okuldaki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("10 - Şubedeki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("11 - Şubedeki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("12 - Öğrencinin not ortalamasını gör ");
            Console.WriteLine("13 - Şubenin not ortalamasını gör    ");
            Console.WriteLine("14 - Öğrencinin okuduğu son kitabı gör ");
            Console.WriteLine("15 - Öğrenci ekle  ");
            Console.WriteLine("16 - Öğrenci gÜncelle");
            Console.WriteLine("17 - Öğrenci sil");
            Console.WriteLine("18 - Öğrencinin adresini gir ");
            Console.WriteLine("19 - Öğrencinin okuduğu kitabı gir ");
            Console.WriteLine("20 - Öğrencinin notunu gir");
            Console.WriteLine();
            Console.WriteLine("Çıkış yapmak için “çıkış” yazıp “enter”a basın.  ");
        }

        public void Listele(int sayi)
        {
            SUBE sube = SUBE.Empty;
            CINSIYET cinsiyet = CINSIYET.Empty;
            DateTime dogumTarihi = DateTime.Now;
            if ((sayi >= 1 && sayi <= 4) || (sayi >= 8 && sayi <= 11))
            {
                if (sayi == 1)
                {
                    Console.WriteLine("1-Bütün Öğrencileri Listele ".PadRight(80, '-'));
                }
                else if (sayi == 2)
                {
                    Console.WriteLine("2-Şubeye Göre Öğrencileri Listele ".PadRight(80, '-'));
                    sube = AracGerecler.subeAl("Listelemek istediğiniz şubeyi girin(A / B / C):");
                }
                else if (sayi == 3)
                {
                    Console.WriteLine("3-Cinsiyetine Göre Öğrencileri Listele ".PadRight(80, '-'));
                    cinsiyet = AracGerecler.cinsiyetAl("Listelemek istediğiniz cinsiyet girin (K/E):");
                }
                else if (sayi == 4)
                {
                    Console.WriteLine("4-Doğum Tarihine Göre Öğrencileri Listele ".PadRight(80, '-'));
                    dogumTarihi = AracGerecler.dogumTarihiAl("Hangi tarihten sonraki ögrencileri listelemek istersiniz:");
                }
                else if (sayi == 8)
                {
                    Console.WriteLine("8-Okuldaki en başarılı 5 öğrenciyi listele ".PadRight(80, '-'));
                }
                else if (sayi == 9)
                {
                    Console.WriteLine("9-Okuldaki en basarısız 3 öğrenciyi listele ".PadRight(80, '-'));
                }
                else if (sayi == 10)
                {
                    Console.WriteLine("10-Şubedeki en basarılı 5 öğrenciyi listele ".PadRight(80, '-'));
                    sube = AracGerecler.subeAl("Listelemek istediğiniz şubeyi girin(A / B / C):");
                }
                else if (sayi == 11)
                {
                    Console.WriteLine("11-Şubedeki en başarısız 3 öğrenciyi listele ".PadRight(80, '-'));
                    sube = AracGerecler.subeAl("Listelemek istediğiniz şubeyi girin(A / B / C):");
                }
                listeleOrtak(okl.ListeGor(sayi, sube, cinsiyet, dogumTarihi));
            }
        }
        public void IlListele()
        {
            Console.WriteLine("5-İllere Göre Öğrencileri Listele ".PadRight(80, '-'));
            Console.WriteLine("Şube".PadRight(12) + "No".PadRight(12) + "Adı Soyadı".PadRight(20) + "Şehir".PadRight(12) + "Semt".PadRight(18));
            Console.WriteLine("".PadRight(80, '-'));
            List<Ogrenci> liste = okl.Ogrenciler.OrderByDescending(a => a.Adresi.Il).ToList();

            if (okl.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Kayıtlı öğrenci yok.");
            }
            else
            {
                foreach (Ogrenci x in liste)
                {
                    Console.WriteLine(x.Sube.ToString().PadRight(12) + x.No.ToString().PadRight(12) + (x.Ad + " " + x.Soyad).PadRight(20) + x.Adresi.Il.PadRight(12) + x.Adresi.Ilce.PadRight(18));
                }
            }
        }

        public void NotListele()
        {
            Console.WriteLine("6-Öğrencinin notlarını görüntüle ".PadRight(80, '-'));
            Ogrenci a = son(bas());

            Console.WriteLine("Dersin Adı".PadRight(13) + "Notu");
            Console.WriteLine("".PadRight(17, '-'));

            if (a.Notlar.Count == 0)
            {
                Console.WriteLine("Öğrencinin aldığı not yok.");
            }
            else
            {
                foreach (DersNotu x in a.Notlar.OrderBy(x => x.DersAdi).ToList())
                {
                    Console.WriteLine(x.DersAdi.PadRight(13) + x.Not);
                }
            }
        }

        public void KitapListele()
        {
            Console.WriteLine("7-Öğrencinin okuduğu kitapları listele ".PadRight(80, '-'));
            Ogrenci a = son(bas());

            Console.WriteLine("Okuduğu Kitaplar");
            Console.WriteLine("".PadRight(17, '-'));
            if (a.Kitaplar.Count == 0)
            {
                Console.WriteLine("Öğrencinin okuduğu kitap yok.");
            }
            else
            {
                foreach (string x in a.Kitaplar)
                {
                    Console.WriteLine(x);
                }
            }
        }

        public void OgrenciOrtalama()
        {
            Console.WriteLine("12-Öğrencinin Not Ortalamasını Gör ".PadRight(69, '-'));
            Ogrenci a = son(bas());
            Console.WriteLine("Öğrencinin Ortalaması: " + a.Ortalama);
        }

        public void SubeOrtalama()
        {
            Console.WriteLine("13-Şubenin Not Ortalamasını Gör ".PadRight(69, '-'));
            SUBE sube = AracGerecler.subeAl("Bir şube seçin (A / B / C):");
            Console.WriteLine(sube + " şubesinin not ortalaması:" + okl.SubeOrtalamasıhesapla(sube));
        }

        public void SonKitap()
        {
            Console.WriteLine("14-Ögrencinin okuduğu son kitabı listele".PadRight(69, '-'));
            Ogrenci a = son(bas());
            Console.WriteLine("Ögrencinin Okuduğu Son Kitap");
            Console.WriteLine("".PadRight(30, '-'));
            Console.WriteLine((a.Kitaplar.Count != 0) ? a.Kitaplar[a.Kitaplar.Count - 1] : "Ögrencinin okuduğu kitap yok.");
        }

        public void OgrenciEkle()
        {
            Console.WriteLine("15-Öğrenci Ekle ".PadRight(69, '-'));
            Console.WriteLine("".PadRight(80, '-'));
            int no = AracGerecler.SayiAl("Öğrencinin numarası: ");
            string ad = AracGerecler.YaziAl("Öğrencinin adı: ");
            string soyad = AracGerecler.YaziAl("Öğrencinin soyadı: ");
            DateTime dogumTarihi = AracGerecler.dogumTarihiAl("Ögrencinin doğum tarihi: ");
            CINSIYET cinsiyet = AracGerecler.cinsiyetAl("Ögrencinin cinsiyeti (K/E): ");
            SUBE sube = AracGerecler.subeAl("Ögrencinin şubesi (A/B/C): ");
            int noeski = no;
            bool deger = true;

            if (OgrenciVarMi(no))
            {
                while (deger)
                {
                    no = no + 1;

                    if (!OgrenciVarMi(no))
                    {
                        deger = false;
                    }
                }
                deger = true;
            }
            Console.Write("Ögrenciyi eklemek istediginize emin misiniz (E / H): ");
            string cevap = Console.ReadLine().ToUpper();
            if (cevap == "E")
            {
                okl.OgrenciEkle(no, ad, soyad, dogumTarihi, cinsiyet, sube);
                Console.WriteLine(no + " numaralı öğrenci sisteme başarılı bir şekilde eklenmiştir.");
            }
            else
            {
                Console.Write("Öğrenci eklenmedi.");
            }
            if (no != noeski)
            {
                Console.WriteLine("Sistemde " + noeski + " numaralı öğrenci olduğu için verdiğiniz öğrenci no " + no + " olarak değiştirildi.");
            }
        }

        public void OgrenciGuncelle()
        {
            Console.WriteLine("16-Ögrenci Güncelle ".PadRight(69, '-'));
            Ogrenci b = bas();

            string o_ad = AracGerecler.YaziAl("Ögrencinin adı: ");
            string o_soyad = AracGerecler.YaziAl("Ögrencinin soyadı: ");
            CINSIYET o_cinsiyet = AracGerecler.cinsiyetAl("Ögrencinin cinsiyeti (K/E):");
            SUBE o_sube = AracGerecler.subeAl("Ögrencinin subesi (A/B/C):");
            Console.Write("Ögrenciyi güncellemek istediginize emin misiniz(E/ H): ");
            string cevap = Console.ReadLine().ToUpper();
            if (cevap == "E")
            {
                if (o_ad != "")
                {
                    b.Ad = o_ad;
                }
                if (o_soyad != "")
                {
                    b.Soyad = o_soyad;
                }
                if (o_cinsiyet != CINSIYET.Empty)
                {
                    b.Cinsiyet = o_cinsiyet;
                }

                if (o_sube != SUBE.Empty)
                {
                    b.Sube = o_sube;
                }
                Console.Write("Ogrenci güncellendi. ");
            }
            else
            {
                Console.Write("Ögrenci güncellenmedi.");
            }
        }

        public void OgrenciSil()
        {
            Console.WriteLine("17-Ögrenci sil ".PadRight(69, '-'));
            int no = ortakKısım();

            Console.Write("Ögrenciyi silmek istediginize emin misiniz(E/ H): ");
            string cevap = Console.ReadLine().ToUpper();
            if (cevap == "E")
            {
                okl.OgrenciSil(no);
                Console.Write("Ögrenci basarılı bir sekilde silindi.");
            }
            else
            {
                Console.Write("Ögrenci silinmedi.");
            }
        }

        public void AdresGir()
        {
            Console.WriteLine("18-Ögrencinin Adresini Gir ".PadRight(69, '-'));
            int no = ortakKısım();
            string il = AracGerecler.YaziAl("Il: ");
            string ilce = AracGerecler.YaziAl("Ilce: ");
            string mahalle = AracGerecler.YaziAl("Mahalle: ");

            Console.Write("Ögrencinin adresini eklemek istediginize emin misiniz(E/ H): ");
            string cevap = Console.ReadLine().ToUpper();
            if (cevap == "E")
            {
                okl.AdresEkle(no, il, ilce, mahalle);
                Console.WriteLine("Bilgiler sisteme girilmistir.");
            }
            else
            {
                Console.Write("Adres eklenmedi.");
            }
        }
        public void KitapGir()
        {
            Console.WriteLine("19-Ögrencinin okudugu kitabı gir ".PadRight(69, '-'));
            int no = ortakKısım();
            string kitapismi = AracGerecler.YaziAl("Eklenecek Kitabin Adı: ");
            okl.KitapEkle(no, kitapismi);
            Console.WriteLine("Bilgiler sisteme girilmistir.");
        }

        static void NotGir()
        {
            Console.WriteLine("20-Not Gir ".PadRight(69, '-'));
            int no = ortakKısım();
            string ders = AracGerecler.YaziAl("Not eklemek istediğiniz ders: ");
            int adet = AracGerecler.SayiAl("Eklemek istediginiz not adedi:");

            for (int i = 1; i <= adet; i++)
            {
                string mesaj = (i + ". Notu girin: ");
                int not = AracGerecler.NotAl(mesaj);
                //int not = int.Parse(Console.ReadLine());

                okl.NotEkle(no, ders, not);
            }
            Console.WriteLine("Not eklendi. ");
        }

        static public bool OgrenciVarMi(int no)
        {
            foreach (Ogrenci a in okl.Ogrenciler)
            {
                if (a.No == no)
                {
                    return true;
                }

            }
            return false;
        }

        static public int ortakKısım()
        {
            Ogrenci b = bas();
            Console.WriteLine("Ögrencinin Adı Soyadı:" + b.Ad + " " + b.Soyad);
            Console.WriteLine("Ögrencinin Subesi:" + b.Sube);
            return b.No;
        }

        static public Ogrenci bas()
        {
            int no = 0;
            Ogrenci b = null;
            while (true)
            {
                no = AracGerecler.SayiAl("Ögrencinin numarası:");
                if (!OgrenciVarMi(no))
                {
                    Console.WriteLine("Bu numarada bir ögrenci yok.Tekrar deneyin.");
                }
                else
                {
                    b = okl.Ogrenciler.Where(a => a.No == no).FirstOrDefault();
                    return b;
                }
            }
        }

        static public Ogrenci son(Ogrenci a)
        {
            Console.WriteLine("Ögrencinin Adı Soyadı: " + a.Ad + " " + a.Soyad);
            Console.WriteLine("Ögrencinin Subesi: " + a.Sube);
            return a;
        }

        static public void listeleOrtak(List<Ogrenci> Ogrenciler)
        {
            Console.WriteLine();
            Console.WriteLine("Şube".PadRight(12) + "No".PadRight(12) + "Adı Soyadı".PadRight(20) + "Not Ort.".PadRight(12) + "Okudugu Kitap Say.".PadRight(18));
            Console.WriteLine("".PadRight(80, '-'));
            if (Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listelenecek öğrenci yok.");
            }
            else
            {
                foreach (Ogrenci x in Ogrenciler)
                {
                    Console.WriteLine(x.Sube.ToString().PadRight(12) + x.No.ToString().PadRight(12) + (x.Ad + " " + x.Soyad).PadRight(20) + x.Ortalama.ToString().PadRight(12) + x.Kitaplar.Count.ToString().PadRight(18));
                }
            }
        }
    }
}