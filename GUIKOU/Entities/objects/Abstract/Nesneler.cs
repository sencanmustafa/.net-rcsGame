using System;
namespace Entities.objects
{
    public abstract class Nesneler
    {
        // Değişkenler
        public String isim;
        public double dayaniklilik;
        public int seviyePuani;
        public bool selected;

        // Fonksiyonlar
        public List<String> nesneOzellikleriGoster()
        {
            List<String> objectProperties = new List<String>();
            objectProperties.Add(isim);
            objectProperties.Add(dayaniklilik.ToString());
            objectProperties.Add(seviyePuani.ToString());
            return objectProperties;
        }

        public virtual double etkiHesapla(double rakipSavunmasi)
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
            this.selected = false;
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

