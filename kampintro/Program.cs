using System;

namespace kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.Kursadi = "C#";


            Console.WriteLine("Hello World!");
        }

    }
    class Kurs
    {
        public string Kursadi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
