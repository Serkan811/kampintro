using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;

            //sayi1 ? cevap - 30 

            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            
            //sayilar1[0] ?  cevap - 999
            
            Console.WriteLine(sayilar1[0]);

            //array, class , interface  referans tiplerdir "new bellekte adres oluşturur"  değerler heap altında saklanır ve değer değişirse her yerde değişir 
            //referansta eşitleme yaparsak referansları eşitler bu yüzden referansın değerlerine eşit olur 
            //int double string bool değer tiptedir verilen değeri o anki sonucuna göre yazar ve ilişkiyi keser


        }
    }
}
