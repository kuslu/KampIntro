﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //TuzelMusteri => CoorparateCustomer
    class TuzelMusteri:Musteri //miras => inheritance
    {
        /* bunlar musteriye taşındı, çünkü tüzel ve gerçek müşteride yer alan ortak bilgidir. o yüzden müşteri class'ına aktarıldı ve burdan inherit edildi
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        */

        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }

    }
}
