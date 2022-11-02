using System;
namespace Entities.objects
{
    public class Tas:Nesneler
    {
        public int katilik;

        public double makasSavunma;
        public double kagitSavunma;

        // Fonksiyonlar

        public void nesneOzellikleriGoster()
        {
            base.nesneOzellikleriGoster();
            Console.WriteLine("Katılık: " + katilik);
        }

        override public double etkiHesapla(double rakipSavunmasi)
        {
            return katilik / rakipSavunmasi;
        }


        public void durumGuncelle(double etki)
        {
            base.durumGuncelle(etki);
        }

        // Constructorlar
        public Tas() : base()
        {
            this.isim = "tas";
            this.katilik = 2;
            this.makasSavunma = 0.8 * this.katilik;
            this.kagitSavunma = 0.2 * this.katilik;
        }

        public Tas(int dayanma, int seviyeP, int kati) : base(dayanma, seviyeP)
        {
            this.isim = "tas";
            this.katilik = kati;
            this.makasSavunma = 0.8 * this.katilik;
            this.kagitSavunma = 0.2 * this.katilik;
        }
    }
}

