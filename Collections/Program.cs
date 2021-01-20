
using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Koray", "Doruk", "Poyraz", "Melek" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            ////Console.WriteLine(isimler[5]); //Dizilerdeki problem genişletemememiz. Yani 5 elemanlı bir dizi oluşturduğumuz zaman altıncı bir eleman eklenemiyor

            List<string> isimler2 = new List<string>() {"Koray","Doruk","Poyraz","Melek" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("Yusuf");
            Console.WriteLine(isimler2[4]);
        }
    }
}
