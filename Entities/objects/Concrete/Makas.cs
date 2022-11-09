using System;
namespace Entities.objects
{
    public class Makas:Nesneler
    {
        public int keskinlik;
        public double tasSavunma;
        public double kagitSavunma;

        // Fonksiyonlar

        public void nesneOzellikleriGoster()
        {
            base.nesneOzellikleriGoster();
            Console.WriteLine("Keskinlik: " + keskinlik);
        }

        override public double etkiHesapla(double rakipSavunmasi)
        {
            return keskinlik / rakipSavunmasi;
        }


        public void durumGuncelle(double etki)
        {
            base.durumGuncelle(etki);
        }

        // Constructorlar
        public Makas() : base()
        {
            this.isim = "makas";
            this.keskinlik = 2;
            this.tasSavunma = 0.2 * keskinlik;
            this.kagitSavunma = 0.8 * keskinlik;
        }

        public Makas(int dayanma, int seviyeP, int keskin) : base(dayanma, seviyeP)
        {
            this.isim = "makas";
            this.keskinlik = keskin;
            this.tasSavunma = 0.2 * keskinlik;
            this.kagitSavunma = 0.8 * keskinlik;
        }
    }
}

