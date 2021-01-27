using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string egitmen = "Yaşar Can";
            int yas = 16;

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = egitmen ;
            kurs1.IzlenmeOrani = 86;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.Egitmen = "Muhammet Ali";
            kurs2.IzlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python";
            kurs3.Egitmen = "Emirhan";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.kursAdi +" "+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2,kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi+" : "+kurs.Egitmen);
            }


        }
        class Kurs
        {
            public string kursAdi { get; set; }

            public string Egitmen { get; set; }

            public int IzlenmeOrani { get; set; }
        }
    }
}
