using System;
namespace Entities.objects
{
    public class OzelKagit:Kagit
    {
        public int kalinlik;

        // Fonksiyonlar

        public void nesneOzellikleriGoster()
        {
            base.nesneOzellikleriGoster();
            Console.WriteLine("Kalınlık: " + kalinlik);
        }

        public double etkiHesapla(double rakipSavunmasi)
        {
            return kalinlik * nufuz / rakipSavunmasi;
        }

        public void durumGuncelle(double etki)
        {
            base.durumGuncelle(etki);
        }

        // Constructorlar
        public OzelKagit() : base()
        {
            this.kalinlik = 2;
            this.tasSavunma *= kalinlik;
            this.makasSavunma *= kalinlik;
        }
        public OzelKagit(int dayanma, int seviyeP, int nuf, int kalin) : base(dayanma, seviyeP, nuf)
        {
            this.kalinlik = kalin;
            this.tasSavunma *= kalinlik;
            this.makasSavunma *= kalinlik;
        }
    }
}

