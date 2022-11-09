using System;
using Entities.objects;

namespace Entities.user
{
    public abstract class Oyuncu
    {
        // Değişkenler
        public int oyuncuID;
        public String oyuncuAdi;
        public int skor;
        public List<Nesneler> nesneListesi = new List<Nesneler>();

        // Fonksiyonlar
        int SkorGoster()
        {
            return skor;
        }


        // Constructorlar
        public Oyuncu()
        {
            this.oyuncuID = 0;
            this.oyuncuAdi = "Oyuncu";
            this.skor = 0;
        }
        public Oyuncu(int ID, String ad)
        {
            this.oyuncuID = ID;
            this.oyuncuAdi = ad;
            this.skor = 0;
        }

    }
}

