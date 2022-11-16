using System;
using Entities.objects;

namespace Entities.user
{
    public class Kullanici:Oyuncu
    {
        // Fonksiyonlar

        Nesneler nesneSec(int index)
        {
            return nesneListesi[index];
        }
        public void nesneleriGoruntule(List<Nesneler> nesneList)
        {
            foreach (Nesneler i in nesneList)
            {
                i.nesneOzellikleriGoster();
            }
        }
        // Constructorlar
        public Kullanici() : base()
        {
        }
        public Kullanici(int ID, String ad) : base(ID, ad)
        {

        }
    }
}

