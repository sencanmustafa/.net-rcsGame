using System;
namespace Entities.objects
{
    public class Kagit:Nesneler
    {
        // Değişkenler

        public int nufuz;

        public double tasSavunma;
        public double makasSavunma;

        // Fonksiyonlar

        public void nesneOzellikleriGoster()
        {
            base.nesneOzellikleriGoster();

        }

        override public double etkiHesapla(double rakipSavunmasi)
        {
            return nufuz / rakipSavunmasi;
        }


        public void durumGuncelle(double etki)
        {
            base.durumGuncelle(etki);
        }

        // Constructorlar
        public Kagit() : base()
        {
            this.isim = "kagit";
            this.nufuz = 2;
            this.tasSavunma = 0.8 * nufuz;
            this.makasSavunma = 0.2 * nufuz;
        }

        public Kagit(int dayanma, int seviyeP, int nuf) : base(dayanma, seviyeP)
        {
            this.isim = "kagit";
            this.nufuz = nuf;
            this.tasSavunma = 0.8 * nufuz;
            this.makasSavunma = 0.2 * nufuz;
        }
    }
}

