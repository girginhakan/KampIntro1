using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Hakan";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Hakan Girgin";
            kurs1.IzlenmeOrani = 80;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Merve Gumusoy Girgin";
            kurs2.IzlenmeOrani = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.KursunEgitmeni = "Gökhan Girgin";
            kurs3.IzlenmeOrani = 85;



            Console.WriteLine(kurs1.KursAdi + ": " + kurs1.KursunEgitmeni + " " + kurs1.IzlenmeOrani);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
