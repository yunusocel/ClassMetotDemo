using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();

        public void MusteriEkle(int mid,string mad,string msad,double mbak)
        {

            Musteri mmsteri = new Musteri();
            mmsteri.MusteriId = mid;
            mmsteri.MusteriAd = mad;
            mmsteri.MusteriSoyad = msad;
            mmsteri.MusteriBakiye = mbak;
            musteriler.Add(mmsteri);
        }

        public void MusteriSil(int mmid)
        {
            for (int i = musteriler.Count - 1; i >= 0; i--)
            {
                if (musteriler[i].MusteriId == mmid)
                {
                    musteriler.RemoveAt(i);
                }
            }



        }

        public void MusteriListele()
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Musteri Id: " + musteri.MusteriId);
                Console.WriteLine("Musteri Adi: " + musteri.MusteriAd);
                Console.WriteLine("Musteri Soyadi: " + musteri.MusteriSoyad);
                Console.WriteLine("Musteri Bakiyesi: " + musteri.MusteriBakiye + "TL");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Musteri Listeleme Bitmistir!");
                Console.WriteLine("---------------------------------------------");
            }
        }

        public void MusteriBilgiGoster(int id)
        {
            foreach (Musteri musteri in musteriler)
            {
                if (musteri.MusteriId == id)
                {
                    Console.WriteLine("Musteri Id: " + musteri.MusteriId);
                    Console.WriteLine("Musteri Adi: " + musteri.MusteriAd);
                    Console.WriteLine("Musteri Soyadi: " + musteri.MusteriSoyad);
                    Console.WriteLine("Musteri Bakiyesi: " + musteri.MusteriBakiye + "TL");
                }
               
            }
        }

        public void MusteriBakiyeSorgula(int id)
        {
            foreach (Musteri musteri in musteriler)
            {
                if (musteri.MusteriId == id)
                {
                    Console.WriteLine(id + " no'lu Musterinin Bakiyesi: " + musteri.MusteriBakiye + "TL");
                }
               
            }
        }
    }
}
