import java.util.*;

public class Oyun {
    public static void main(String[] args) {
        System.out.println("Hello world!");
    }
}
abstract class Silah {
    // Değişkenler
    int dayaniklilik;
    int seviyePuani;

    // Fonksiyonlar
    void nesnePuaniGoster() {
        System.out.println("Dayanıklılık: " + dayaniklilik);
        System.out.println("Seviye Puanı: " + seviyePuani);
    }
    int etkiHesapla() {
        return 0;
    }
    void durumGuncelle(int etki) {
        this.dayaniklilik -= etki;
        // Seviye puanı hesaplama kodları buraya gelecek.
    }

    // Constructorlar
    public Silah() {
        this.dayaniklilik = 20;
        this.seviyePuani = 0;
    }
    public Silah(int dayanma, int seviyeP) {
        this.dayaniklilik = dayanma;
        this.seviyePuani = seviyeP;
    }
}

// Taş ve alt class'ları

class Tas extends Silah {
    // Değişkenler
    int katilik;
    double makasSavunma;
    double kagitSavunma;

    // Fonksiyonlar
    @Override
    void nesnePuaniGoster() {
        super.nesnePuaniGoster();
        System.out.println("Katılık: " + katilik);
    }
    double etkiHesapla(double rakipSavunmasi) {
        return katilik / rakipSavunmasi;
    }
    @Override
    void durumGuncelle(int etki) {
        super.durumGuncelle(etki);
    }

    // Constructorlar
    public Tas() {
        super();
        this.katilik = 2;
        this.makasSavunma = 0.8 * this.katilik;
        this.kagitSavunma = 0.2 * this.katilik;
    }
    public Tas(int dayanma, int seviyeP, int kati) {
        super(dayanma, seviyeP);
        this.katilik = kati;
        this.makasSavunma = 0.8 * this.katilik;
        this.kagitSavunma = 0.2 * this.katilik;
    }
}
class AgirTas extends Tas {
    // Değişkenler
    int sicaklik;

    // Fonksiyonlar
    @Override
    void nesnePuaniGoster() {
        super.nesnePuaniGoster();
        System.out.println("Sıcaklık: " + sicaklik);
    }
    @Override
    double etkiHesapla(double rakipSavunmasi) {
        return katilik * sicaklik / rakipSavunmasi;
    }
    @Override
    void durumGuncelle(int etki) {
        super.durumGuncelle(etki);
    }

    // Constructorlar
    public AgirTas() {
        super();
        this.sicaklik = 2;
        this.makasSavunma *= this.sicaklik;
        this.kagitSavunma *= this.sicaklik;
    }
    public AgirTas(int dayanma, int seviyeP, int kati, int sicak) {
        super(dayanma, seviyeP, kati);
        this.sicaklik = sicak;
        this.makasSavunma *= this.sicaklik;
        this.kagitSavunma *= this.sicaklik;
    }
}

// Kağıt ve alt class'ları

class Kagit extends Silah {
    // Değişkenler
    int nufuz;
    double tasSavunma;
    double makasSavunma;

    // Fonksiyonlar
    @Override
    void nesnePuaniGoster() {
        super.nesnePuaniGoster();
        System.out.println("Nüfuz: " + nufuz);
    }
    double etkiHesapla(double rakipSavunmasi) {
        return nufuz / rakipSavunmasi;
    }
    @Override
    void durumGuncelle(int etki) {
        super.durumGuncelle(etki);
    }

    // Constructorlar
    public Kagit() {
        super();
        this.nufuz = 2;
        this.tasSavunma = 0.8 * nufuz;
        this.makasSavunma = 0.2 * nufuz;
    }
    public Kagit(int dayanma, int seviyeP, int nuf) {
        super(dayanma, seviyeP);
        this.nufuz = nuf;
        this.tasSavunma = 0.8 * nufuz;
        this.makasSavunma = 0.2 * nufuz;
    }
}
class OzelKagit extends Kagit {
    // Değişkenler
    int kalinlik;

    // Fonksiyonlar
    @Override
    void nesnePuaniGoster() {
        super.nesnePuaniGoster();
        System.out.println("Kalınlık: " + kalinlik);
    }
    @Override
    double etkiHesapla(double rakipSavunmasi) {
        return kalinlik * nufuz / rakipSavunmasi;
    }
    @Override
    void durumGuncelle(int etki) {
        super.durumGuncelle(etki);
    }

    // Constructorlar
    public OzelKagit() {
        super();
        this.kalinlik = 2;
        this.tasSavunma *= kalinlik;
        this.makasSavunma *= kalinlik;
    }
    public OzelKagit(int dayanma, int seviyeP, int nuf, int kalin) {
        super(dayanma, seviyeP, nuf);
        this.kalinlik = kalin;
        this.tasSavunma *= kalinlik;
        this.makasSavunma *= kalinlik;
    }
}

// Makas ve alt class'ları

class Makas extends Silah {
    // Değişkenler
    int keskinlik;
    double tasSavunma;
    double kagitSavunma;

    // Fonksiyonlar
    @Override
    void nesnePuaniGoster() {
        super.nesnePuaniGoster();
        System.out.println("Keskinlik: " + keskinlik);
    }
    double etkiHesapla(double rakipSavunmasi) {
        return keskinlik / rakipSavunmasi;
    }
    @Override
    void durumGuncelle(int etki) {
        super.durumGuncelle(etki);
    }

    // Constructorlar
    public Makas() {
        super();
        this.keskinlik = 2;
        this.tasSavunma = 0.2 * keskinlik;
        this.kagitSavunma = 0.8 * keskinlik;
    }
    public Makas(int dayanma, int seviyeP, int keskin) {
        super(dayanma, seviyeP);
        this.keskinlik = keskin;
        this.tasSavunma = 0.2 * keskinlik;
        this.kagitSavunma = 0.8 * keskinlik;
    }
}
class UstaMakas extends Makas {
    // Değişkenler
    int hiz;

    // Fonksiyonlar
    @Override
    void nesnePuaniGoster() {
        super.nesnePuaniGoster();
        System.out.println("Hız: " + hiz);
    }
    @Override
    double etkiHesapla(double rakipSavunmasi) {
        return hiz * keskinlik / rakipSavunmasi;
    }
    @Override
    void durumGuncelle(int etki) {
        super.durumGuncelle(etki);
    }

    // Constructorlar
    public UstaMakas() {
        super();
        this.hiz = 2;
        this.tasSavunma *= hiz;
        this.kagitSavunma *= hiz;
    }
    public UstaMakas(int dayanma, int seviyeP, int keskin, int surat) {
        super(dayanma, seviyeP, keskin);
        this.hiz = surat;
        this.tasSavunma *= hiz;
        this.kagitSavunma *= hiz;
    }
}

abstract class Oyuncu {
    // Değişkenler
    int oyuncuID;
    String oyuncuAdi;
    int skor;
    List<Object> nesneListesi = new ArrayList<Object>();

    // Fonksiyonlar
    int SkorGoster() {
        return skor;
    }
    abstract Object nesneSec(int index);

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
    Object nesneSec(int index) { // Buradaki index random atılmalı.
        return nesneListesi.get(index);
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
    Object nesneSec(int index) {
        return nesneListesi.get(index);
    }

    // Constructorlar
    public Kullanici() {
        super();
    }
    public Kullanici(int ID, String ad) {
        super(ID, ad);
    }
}
