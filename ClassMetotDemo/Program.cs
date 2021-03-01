using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            //musteri.Ad = "Oğuzhan";
            //musteri.Soyad = "Kandar";
            //musteri.Sehir = "Kocaeli";
            //musteri.Id = 1;



            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri);
            musteriManager.List(musteri);
            musteriManager.Delete(musteri);
        }
    }
}
