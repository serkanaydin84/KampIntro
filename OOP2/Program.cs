using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 2;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Serkan";
            musteri1.Soyadi = "Aydın";
            musteri1.TcNo = "2222222";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 3;
            musteri2.MusteriNo = "121234";
            musteri2.SirketAdi = "SaSoft";
            musteri2.VergiNo = "31613";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);
        }
    }
}
