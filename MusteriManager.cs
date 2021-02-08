using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "- " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Sehir + " Eklendi.");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "- " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Sehir + " Silindi.");
        }
        public void List(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + "- " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Sehir);
            }
        }
    }
}
