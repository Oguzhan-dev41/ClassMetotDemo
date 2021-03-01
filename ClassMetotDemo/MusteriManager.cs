using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "Musteri Eklendi ! ");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "Musteri Listelendi ! ");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "Musteri Silindi !");
        }

    }
}
