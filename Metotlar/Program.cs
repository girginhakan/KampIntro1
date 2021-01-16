using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Product urun2 = new Product();
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] {urun1,urun2};


            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
            }


            Console.WriteLine("--------------Metotlar---------------");

            //instance-örnek

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil", 12,10);
            sepetManager.Ekle2("Mandalina", "Yeşil", 18,24);
            sepetManager.Ekle2("Üzüm", "Siyah", 15,30);
            sepetManager.Ekle2("Kivi", "Sarı", 20,5);


        }
    }
}
