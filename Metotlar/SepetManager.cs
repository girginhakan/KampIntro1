using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming conversion
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler Sepete eklendi : " + urun.UrunAdi);
        }


        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler sepete eklendi : " + urunAdi);
        }
    }
}
