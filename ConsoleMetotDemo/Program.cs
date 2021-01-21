using System;

namespace ConsoleMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();
            Musteri musteri4 = new Musteri();

            musteri1.Id = 1;
            musteri1.Ad = "Serkan ";
            musteri1.SoyAd = "Cebeci ";
            musteri1.Yas = " 20";

            
            musteri2.Id = 2;
            musteri2.Ad = "Ahmet ";
            musteri2.SoyAd = "Engin ";
            musteri2.Yas = " 20";

            
            musteri3.Id = 3;
            musteri3.Ad = "Günay ";
            musteri3.SoyAd = "Çavuş ";
            musteri3.Yas = " 19";

            
            musteri4.Id = 4;
            musteri4.Ad = "Serhat ";
            musteri4.SoyAd = "Boz ";
            musteri4.Yas = " 23";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);
            Console.WriteLine("----------------------------");

            musteriManager.MusteriDelete(musteri2);
            Console.WriteLine("----------------------------");

            musteriManager.MusteriList(musteri1);
            musteriManager.MusteriList(musteri2);
            musteriManager.MusteriList(musteri3);
            musteriManager.MusteriList(musteri4);








        }
    }
}
