using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClassDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + "  " + "İSİMLİ MüŞTERİ EKLENDİ");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + "  " + "İSİMLİ MÜŞTERİ SİLİNDİ");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("MÜŞTERİ BİLGİLERİ " + musteri.Id + "  " + musteri.MusteriAdi + "  " + musteri.MusteriSoyadi + "  " + musteri.Cinsiyet + "  " + musteri.DogumTarihi + "  " + musteri.Konum);
        }
    }
}
