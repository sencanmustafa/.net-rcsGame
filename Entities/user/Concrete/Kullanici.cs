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

        // Constructorlar
        public Kullanici() : base()
        {
        }
        public Kullanici(int ID, String ad) : base(ID, ad)
        {

        }
    }
}

