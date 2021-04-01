using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi +" "+ "isimli kullanıcı sisteme başarıyla eklendi.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi +" "+ "isimli kullanıcı sistemden başarıyla silindi.");
        }
    }
}
