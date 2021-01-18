using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class MusteriManager
    {
        public void mEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + " " + musteri.Adi + " " + " " + musteri.Soyadi + " Eklendi");
        }

        public void mListele(Musteri[] musteriler)
        {

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.HesapBakiye);
            }
        }
        public void mSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "  Numaralı Muşteri Silindi.");
        }
    }
}
