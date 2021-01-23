using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* inherit edildikten sonra bunlar iptal edildi:
            //Misal bankada yeni bir müşteri hesabı açacağız
            //Banka müşterisi Gerçek veya Tüzel bir müşteri olabilir.
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.Id = 1;
            musteri1.TcNo = "22222222220";
            musteri1.MusteriNo = "12345";
            musteri1.SirketAdi = "?";   //Gerçek müşteri olduğu için şirket adı yer almaz. Böyle bir kullanım yanlıştır.
                                        //Bu verinin musteri alanında yer almaması lazım
           */
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Koray";
            musteri1.Soyadi = "USLU";
            musteri1.TcNo = "222222222222222";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi="Uslu Motor";
            musteri2.VergiNo = "5555555555";

            Musteri musteri3 = new GercekMusteri(); //Musteri class'ı hem gerçek müşterinin referansını tutabiliyor
            Musteri musteri4 = new TuzelMusteri(); //Musteri class'ı hem de tüzel müşterinin referansını tutabiliyor

            CustomerManager musteriManager = new CustomerManager(); 
            musteriManager.Add(musteri1); // müşteriManager burda da görüldüğü gibi hem Gerçek Müşteriyi
            musteriManager.Add(musteri2); // hem de Tüzel Müşteriyi işleyebiliyor/kabul ediyor


        }
    }
}
