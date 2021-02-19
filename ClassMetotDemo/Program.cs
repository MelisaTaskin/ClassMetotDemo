using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.AdiSoyadi = "Cemile Kocabaş";
            musteri1.KartTuru = "Banka Kartı";
            musteri1.Bakiye = 5000;


            Musteri musteri2 = new Musteri();
            musteri2.AdiSoyadi = "Kader Altun";
            musteri2.KartTuru = "Kredi Kartı";
            musteri2.Bakiye = 6520;

            Musteri musteri3 = new Musteri();
            musteri3.AdiSoyadi = "Ayşe Aslan";
            musteri3.KartTuru = "Kredi Kartı";
            musteri3.Neden = "Ödenmeyen Borç";



            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Ekle2(musteri3);












            
        }
    }
}
