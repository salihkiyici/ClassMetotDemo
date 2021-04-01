using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 001;
            musteri1.MusteriAdi = "Kemal";
            musteri1.MusteriSoyadi = "Yılmaz";
            musteri1.TcKimlikNo = "12132546567";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 002;
            musteri2.MusteriAdi = "Yiğit";
            musteri2.MusteriSoyadi = "Kahraman";
            musteri2.TcKimlikNo = "65464651657";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
        }
    }
}
