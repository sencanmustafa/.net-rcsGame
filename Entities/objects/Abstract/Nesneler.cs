using System;
namespace Entities.objects
{
    public abstract class Nesneler
    {
        // Değişkenler
        public String isim;
        public double dayaniklilik;
        public int seviyePuani;

        // Fonksiyonlar
        public void nesneOzellikleriGoster()
        {
            Console.WriteLine("Nesne Ismi : " + isim);
            Console.WriteLine("Dayanıklılık: " + dayaniklilik);
            Console.WriteLine("Seviye Puanı: " + seviyePuani);
        }

        public double etkiHesapla(double rakipSavunmasi)
        {
            return 0;
        }

        public void durumGuncelle(double etki)
        {
            this.dayaniklilik -= etki;

            // Seviye puanı hesaplama kodları buraya gelecek.
        }

        // Constructorlar
        public Nesneler()
        {
            this.dayaniklilik = 20;
            this.seviyePuani = 0;
        }

        public Nesneler(int dayanma, int seviyeP)
        {

            this.dayaniklilik = dayanma;
            this.seviyePuani = seviyeP;
        }
    }
}

