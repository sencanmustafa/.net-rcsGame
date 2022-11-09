using System;
namespace Entities.objects
{
    public class AgirTas:Tas
    {
        // Değişkenler
        public int sicaklik;

        // Fonksiyonlar

        public void nesneOzellikleriGoster()
        {
            base.nesneOzellikleriGoster();
            Console.WriteLine("Sıcaklık: " + sicaklik);
        }


        override public double etkiHesapla(double rakipSavunmasi)
        {
            return (katilik * sicaklik) / rakipSavunmasi;
        }


        public void durumGuncelle(double etki)
        {
            base.durumGuncelle(etki);
        }

        // Constructorlar
        public AgirTas() : base()
        {
            this.sicaklik = 2;
            this.makasSavunma *= this.sicaklik;
            this.kagitSavunma *= this.sicaklik;
        }

        public AgirTas(int dayanma, int seviyeP, int kati, int sicak) : base(dayanma, seviyeP, kati)
        {
            this.sicaklik = sicak;
            this.makasSavunma *= this.sicaklik;
            this.kagitSavunma *= this.sicaklik;
        }
    }
}

