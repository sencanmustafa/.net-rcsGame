using System;
using Entities.objects;

namespace Entities.user
{
    public class Bilgisayar:Oyuncu
    {
        // Fonksiyonlar

        //random alacak
        public Nesneler nesneSec(int index)
        { // Buradaki index random atılmalı.
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
        public Bilgisayar() : base()
        {
        }
        public Bilgisayar(int ID, String ad) : base(ID, ad)
        {
        }
    }
}

