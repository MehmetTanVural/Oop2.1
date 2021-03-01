using System;

namespace Oop2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Ad = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.MusteriNo = "54321";
            musteri2.VergiNo = "999";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri2);


        }
    }
}
