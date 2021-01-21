using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Koray");
            Console.WriteLine("Şuan Listemizde " + isimler.Length+" kişi var.");

            isimler.Add("Melek");
            isimler.Add("Doruk");
            Console.WriteLine("Şuan Listemizde " + isimler.Length + " kişi var.");

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
           
        }
    }
}
