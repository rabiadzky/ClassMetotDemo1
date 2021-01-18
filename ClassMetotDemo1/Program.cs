using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.Id = 101;
            m1.Adi = "Ali";
            m1.Soyadi = "Kar";
            m1.HesapBakiye = 606.20;

            Musteri m2 = new Musteri();
            m2.Id = 102;
            m2.Adi = "Ayşe";
            m2.Soyadi = "Doğan";
            m2.HesapBakiye = 1500.50;

            Musteri m3 = new Musteri();
            m3.Id = 103;
            m3.Adi = "Baki";
            m3.Soyadi = "Doğru";
            m3.HesapBakiye = 250;

            Musteri[] musteriler = new Musteri[] { m1, m2, m3 };

            MusteriManager musman = new MusteriManager();

            Console.WriteLine("-----------Ekle----------");
            musman.mEkle(m1);
            musman.mEkle(m2);
            musman.mEkle(m3);

            Console.WriteLine("-----------Listele--------");
            musman.mListele(musteriler);

            Console.WriteLine("-----------Sil------------");
            musman.mSil(m2);
            musman.mSil(m1);
        }
    }
}
