using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1,kurs2,kurs3,kurs4,kurs5;

            kurs1 = "Yazılım Geliştirme Kampı";
            kurs2 = "Porgramlamaya Başlamak İçin Temel Kurs";
            kurs3 = "Java";
            kurs4 = "Python";
            kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);

            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);


            //array - dizi.

            string[] kurslar = new string[]
            {
               "Yazılım Geliştirme Kampı","Porgramlamaya Başlamak İçin Temel Kurs","Java","Python","C++"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
