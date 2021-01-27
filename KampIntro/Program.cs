using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type - Safety = Tip Güvenliği.

            Console.ForegroundColor = ConsoleColor.DarkGreen;  

            string kategoriEtiketi = "Kategori";
            int ögrenciSayısı = 32000;
            double faizOrani = 1.45;
            bool sistemeGirişyapmisMI = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi Oku");
            }

            if (sistemeGirişyapmisMI == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.ReadLine();
        }
    }
}
