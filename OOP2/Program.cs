using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Gerçek müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Hakan";
            musteri1.Soyadi = "Girgin";
            musteri1.TcNo = "11111111111";


            //Merve'nin Şirketi

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Merve'nin şirketi";
            musteri2.VergiNo = "2222222222222";




            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


            //Gerçek Müşteri --- Tüzel Müşteri
        }
    }
}
