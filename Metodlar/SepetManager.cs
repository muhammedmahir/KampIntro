using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention isimlendirme kuralı
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler sepete eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, String aciklama, double fiyat, double stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi. " + urunAdi);
        }

    }
}
