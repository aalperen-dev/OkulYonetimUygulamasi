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
    public class AracGerecler
    {
        static public string SecimAl()
        {
            Console.Write("Yapmak istediğiniz işlemi seçin : ");
            return Console.ReadLine().ToLower();
        }

        static public int SayiAl(string mesaj)
        {
            int sayi;
            do
            {
                try
                {
                    Console.Write(mesaj);
                    string giris = Console.ReadLine();

                    if (int.TryParse(giris, out sayi))
                    {
                        return sayi;
                    }
                    else
                    {
                        throw new Exception("Giriş tanımlamanadı. Tekrar deneyin.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
        }

        static public int NotAl(string mesaj)
        {
            int sayi;
            do
            {
                try
                {
                    Console.Write(mesaj);
                    string giris = Console.ReadLine();

                    if (int.TryParse(giris, out sayi))
                    {
                        if (int.Parse(giris) >= 0 && int.Parse(giris) <= 100)
                        {
                            return sayi;
                        }
                        else
                        {
                            Console.WriteLine("Gireceğiniz deger 0-100 arası olmalıdır.");
                        }
                    }
                    else
                    {
                        throw new Exception("Giriş tanımlanamadı. Tekrar deneyin.");
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            } while (true);
        }

        static public string YaziAl(string mesaj)
        {
            Console.Write(mesaj);
            string giris = Console.ReadLine().ToUpper();
            if (giris.Length > 1)
            {
                return giris.Substring(0, 1).ToUpper() + giris.Substring(1).ToLower();
            }
            else
            {
                return giris.ToUpper();
            }
        }

        static public DateTime dogumTarihiAl(string mesaj)
        {
            while (true)
            {
                try
                {
                    Console.Write(mesaj);
                    string tarih = Console.ReadLine();
                    DateTime sayi;

                    switch (DateTime.TryParse(tarih, out sayi))
                    {
                        case true:
                            return sayi;
                        default:
                            throw new Exception("Giriş tanımlanamadı. Tekrar deneyin.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static public CINSIYET cinsiyetAl(string mesaj)
        {
            while (true)
            {
                try
                {
                    Console.Write(mesaj);
                    string secim = Console.ReadLine().ToUpper();

                    switch (secim)
                    {
                        case "K":
                            return CINSIYET.Kiz;

                        case "E":
                            return CINSIYET.Erkek;
                        case "":
                            return CINSIYET.Empty;
                        default:
                            throw new Exception("Giriş tanımlanamadı. Tekrar deneyin.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static public SUBE subeAl(string mesaj)
        {
            while (true)
            {
                try
                {
                    Console.Write(mesaj);
                    string secim = Console.ReadLine().ToUpper();

                    switch (secim)
                    {
                        case "A":
                            return SUBE.A;

                        case "B":
                            return SUBE.B;

                        case "C":
                            return SUBE.C;

                        case "":
                            return SUBE.Empty;

                        default:
                            throw new Exception("Giriş tanımlanamadı. Tekrar deneyin.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}