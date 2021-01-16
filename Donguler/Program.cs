using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //statik yapı - negatif. bu sistemler çalışmaz
            string kurs1 = "Yaz. Geliştirici";
            string kurs2 = "Prog.Giriş";
            string kurs3 = "Java";
            string kurs4 = "Phyton";
            string kurs5 = "C++";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
            Console.WriteLine("");

            //Array -Dizi. dinamik yapı bu tip sistemler kullanılır
            string[] kurslar = new string[] {"Yaz. Geliştirici", "Prog. Giriş", "Java","Phyton","C++"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine(""); //Boşluk ver

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu - footer");
            
        }
    }
}
