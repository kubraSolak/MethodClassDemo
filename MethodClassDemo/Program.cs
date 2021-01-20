using System;

namespace MethodClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 11111111111;
            musteri1.MusteriAdi = "Sara";
            musteri1.MusteriSoyadi = "Key";
            musteri1.Cinsiyet = "Kadın";
            musteri1.DogumTarihi = new DateTime(1996, 12, 2);
            musteri1.Konum = "Neverland";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 22222222222;
            musteri2.MusteriAdi = "Dmitry";
            musteri2.MusteriSoyadi = "Obromov";
            musteri2.Cinsiyet = "Erkek";
            musteri2.DogumTarihi = new DateTime(1990, 3, 15);
            musteri2.Konum = "Russia";


            Musteri musteri3 = new Musteri();
            musteri3.Id = 33333333333;
            musteri3.MusteriAdi = "EunWo";
            musteri3.MusteriSoyadi = "Cha";
            musteri3.Cinsiyet = "Erkek";
            musteri3.DogumTarihi = new DateTime(1997, 3, 30);
            musteri3.Konum = "South Korea";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 44444444444;
            musteri4.MusteriAdi = "Annie";
            musteri4.MusteriSoyadi = "Knight";
            musteri4.Cinsiyet = "Kadın";
            musteri4.DogumTarihi = new DateTime(1996, 7, 21);
            musteri4.Konum = "USA";


            Musteri musteri5 = new Musteri();
            musteri5.Id = 55555555555;
            musteri5.MusteriAdi = "Sasha";
            musteri5.MusteriSoyadi = "Felt";
            musteri5.Cinsiyet = "Kadın";
            musteri5.DogumTarihi = new DateTime(1992, 10, 9);
            musteri5.Konum = "Germany";

            Musteri musteri6 = new Musteri();
            musteri6.Id = 66666666666;
            musteri6.MusteriAdi = "Eren";
            musteri6.MusteriSoyadi = "Demir";
            musteri6.Cinsiyet = "Erkek";
            musteri6.DogumTarihi = new DateTime(1994, 9, 2);
            musteri6.Konum = "Turkey";

            Musteri musteri7 = new Musteri();
            musteri7.Id = 77777777777;
            musteri7.MusteriAdi = "Kirigaya";
            musteri7.MusteriSoyadi = "Kazuto";
            musteri7.Cinsiyet = "Erkek";
            musteri7.DogumTarihi = new DateTime(1996, 12, 2);
            musteri7.Konum = "Japan";



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5, musteri6, musteri7 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine(musteri.Cinsiyet);
                Console.WriteLine(musteri.DogumTarihi);
                Console.WriteLine(musteri.Konum);
                Console.WriteLine("               ");
                Console.WriteLine("               ");
            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteri7);
            musteriManager.Ekle(musteri5);
            musteriManager.Sil(musteri2);
        }
    }
}
