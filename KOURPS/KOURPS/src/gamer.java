import items.Nesneler;

import java.util.ArrayList;
import java.util.List;

abstract class Oyuncu {
    // Değişkenler
    int oyuncuID;
    String oyuncuAdi;
    int skor;
    List<Nesneler> nesneListesi = new ArrayList<Nesneler>();

    // Fonksiyonlar
    int SkorGoster() {
        return skor;
    }
    abstract Nesneler nesneSec(int index);

    // Constructorlar
    public Oyuncu() {
        this.oyuncuID = 0;
        this.oyuncuAdi = "Oyuncu";
        this.skor = 0;
    }
    public Oyuncu(int ID, String ad) {
        this.oyuncuID = ID;
        this.oyuncuAdi = ad;
        this.skor = 0;
    }
}

class Bilgisayar extends Oyuncu {
    // Fonksiyonlar
    @Override
    //random alacak
    public Nesneler nesneSec(int index)
    { // Buradaki index random atılmalı.
        return nesneListesi.get(index);
    }
    public void nesneleriGoruntule(List<Nesneler> nesneList)
    {
        for (Nesneler i:nesneList)
        {
            i.nesneOzellikleriGoster();
        }
    }
    // Constructorlar
    public Bilgisayar() {
        super();
    }
    public Bilgisayar(int ID, String ad) {
        super(ID, ad);
    }

}

class Kullanici extends Oyuncu {
    // Fonksiyonlar
    @Override
    Nesneler nesneSec(int index)
    {
        return nesneListesi.get(index);
    }

    // Constructorlar
    public Kullanici() {
        super();
    }
    public Kullanici(int ID, String ad)
    {
        super(ID, ad);
    }
}
