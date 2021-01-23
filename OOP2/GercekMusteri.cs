using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //BireyselMusteri => Eng:IndividualCustomer
    class GercekMusteri:Musteri //miras => inheritance
    {
        /* bunlar musteriye taşındı, çünkü tüzel ve gerçek müşteride yer alan ortak bilgidir. o yüzden müşteri class'ına aktarıldı ve burdan inherit edildi
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        */
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
