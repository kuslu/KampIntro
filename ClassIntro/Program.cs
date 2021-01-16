using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Koray";
            int yas = 40;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlemeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Koray USLU";
            kurs2.IzlemeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Y. Doruk USLU";
            kurs3.IzlemeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Poyraz USLU";
            kurs4.IzlemeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi+" : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.Egitmen);

            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlemeOrani { get; set; }

    }
}
