using System;
using Entities.objects;

namespace Entities.user
{
    public abstract class Oyuncu
    {
        // Değişkenler
        public int oyuncuID;
        public String oyuncuAdi;
        public double skor;
        public List<Nesneler> nesneListesi = new List<Nesneler>();

        // Fonksiyonlar
        double SkorGoster()
        {
            for(int x = 0; x < nesneListesi.Count; x++)
            {
                skor += nesneListesi[x].dayaniklilik;

            }
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

