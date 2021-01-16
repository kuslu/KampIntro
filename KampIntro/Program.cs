using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği
            //do not repeat yourself - Kendini tekrarlama
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonunu göster");
            }
            else 
            {
                Console.WriteLine("değişmedi");
            }

            
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            
        }
    }
}
