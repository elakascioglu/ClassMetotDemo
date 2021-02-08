using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 0;
            musteri1.Adi = "Ela";
            musteri1.Soyadi = "Kaşcıoğlu";
            musteri1.Sehir = "Istanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1;
            musteri2.Adi = "Hatice";
            musteri2.Soyadi = "Kaya";
            musteri2.Sehir = "Malatya";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 2;
            musteri3.Adi = "Kader";
            musteri3.Soyadi = "Sutlu";
            musteri3.Sehir = "Istanbul";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            Console.WriteLine("\n---------Müşteriler Eklendi--------\n");

            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Delete(musteri3);
            Console.WriteLine("\n---------Müşteriler Silindi---------\n");
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);
            }
            Console.WriteLine("\n---------Müşteriler Listelendi---------\n");
        }
    }
}
