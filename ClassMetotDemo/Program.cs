using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            Musteri mstri=new Musteri();
            MusteriManager musteriManager = new MusteriManager(); 

            while (true)
            {
                command1:

                Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz..");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("1- Musteri Ekleme");
                Console.WriteLine("2- Musteri Silme");
                Console.WriteLine("3- Musterileri Listeleme");
                Console.WriteLine("4- Musteri Bilgi Gosterme");
                Console.WriteLine("5- Musteri Bakiye Sorgulama");
                Console.WriteLine("6- Cikis..");
                Console.WriteLine("---------------------------------------------");

                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Musteri Id:");
                        int musId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Musteri Adi:");
                        string musAd = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Musteri Soyadi:");
                        string musSoyad = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Musteri Bakiye(TL):");
                        double musBakiye = Convert.ToDouble(Console.ReadLine());
                        musteriManager.MusteriEkle(musId,musAd,musSoyad,musBakiye);
                        Console.WriteLine("---------------------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Musteri Id:");
                        int mussId = Convert.ToInt32(Console.ReadLine());
                        musteriManager.MusteriSil(mussId);
                        Console.WriteLine("---------------------------------------------");
                        musteriManager.MusteriListele();
                        break;
                    case 3:
                        Console.WriteLine("Tüm müsterilerimiz:");
                        Console.WriteLine("---------------------------------------------");
                        musteriManager.MusteriListele();
                        
                        break;
                    case 4:
                        Console.WriteLine("Musteri Id:");
                        int musteriId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(musteriId + " no'lu musteri bilgileri:");
                        Console.WriteLine("---------------------------------------------");
                        musteriManager.MusteriBilgiGoster(musteriId);
                        Console.WriteLine("---------------------------------------------");
                        break;
                    case 5:
                        Console.WriteLine("Musteri Id:");
                        int msId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(msId + " no'lu musterinin bakiye bilgileri:");
                        Console.WriteLine("---------------------------------------------");
                        musteriManager.MusteriBakiyeSorgula(msId);
                        Console.WriteLine("---------------------------------------------");
                        break;
                    case 6:
                        goto command1;
                        
                    default:
                        Console.WriteLine("Yanlis bir tuslama yaptiniz! Lutfen dogru tuslama yapiniz..");
                        goto command1;

                }
            }
        }
    }
}
