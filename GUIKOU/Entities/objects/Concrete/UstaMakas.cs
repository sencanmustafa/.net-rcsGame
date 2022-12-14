using System;
namespace Entities.objects
{
    public class UstaMakas:Makas
    {
        // Değişkenler
        public int hiz;

        // Fonksiyonlar

        public void nesneOzellikleriGoster()
        {
            base.nesneOzellikleriGoster();
            Console.WriteLine("Hız: " + hiz);
        }


        override public double etkiHesapla(double rakipSavunmasi)
        {
            return hiz * keskinlik / rakipSavunmasi;
        }


        public void durumGuncelle(double etki)
        {
            base.durumGuncelle(etki);
        }

        // Constructorlar
        public UstaMakas() : base()
        {
            this.isim = "UstaMakas";
            this.hiz = 2;
            this.tasSavunma *= hiz;
            this.kagitSavunma *= hiz;
        }

        public UstaMakas(int dayanma, int seviyeP, int keskin, int surat) : base(dayanma, seviyeP, keskin)
        {
            this.isim = "UstaMakas";
            this.hiz = surat;
            this.tasSavunma *= hiz;
            this.kagitSavunma *= hiz;
        }
    }
}

