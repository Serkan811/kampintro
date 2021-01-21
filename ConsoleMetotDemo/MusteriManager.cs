using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMetotDemo
{
    class MusteriManager
    {

        public void Add(Musteri musteri
            )
        {
            Console.WriteLine(musteri.Ad + " eklendi.");
        }

        public void MusteriAdd(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri: "  + "ID: " + musteri.Id + " İsmi: " + musteri.Ad + " --- "  +  " Soyisim: " + musteri.SoyAd + " Yaş: " +  musteri.Yas);
        }
        public void MusteriDelete(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşteri: " + " ID: " + musteri.Id + " İsmi: " + musteri.Ad + " --- " + " Soyisim: " + musteri.SoyAd + "   Yaş: " + musteri.Yas);
        }
        public void MusteriList(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi: " + "Id: " + musteri.Id + " İsmi: " + musteri.Ad + " --- " + "  Soyisim: " + musteri.SoyAd + "  Yaş: " +   musteri.Yas);
        }

        


    }
}
