using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {
        //Bir class'ın 2 işlevi vardır: Özellik tutar, Method çalıştırır

        //kötü kod dediğimiz örnek: sektörde çoğunlukla yapılan hata budur:
        /* Bunlar Gerçek Müşteri kısmına alındı
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string  Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
        */

        /*Bunlar ise Tüzel Muşteri class'ına ait olmalı, oraya alındı
        public string SirketAdi { get; set; }
        
        public string VergiNo { get; set; }
        */

        //gerçek ve tüzel müşteri classlarına müşteri inheritance edildikten sonra bunlar buraya taşındı
        public int Id { get; set; }
        public string MusteriNo { get; set; }

    }
}
