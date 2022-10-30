package items;

public class OzelKagit extends Kagit {
    // Değişkenler
    public String isim;
    public int kalinlik;

    // Fonksiyonlar
    @Override
    public void nesneOzellikleriGoster() {
        super.nesneOzellikleriGoster();
        System.out.println("Nesne Ismi : " + isim);
        System.out.println("Kalınlık: " + kalinlik);
    }
    @Override
    public double etkiHesapla(double rakipSavunmasi) {
        return kalinlik * nufuz / rakipSavunmasi;
    }
    @Override
    public void durumGuncelle(double etki) {
        super.durumGuncelle(etki);
    }

    // Constructorlar
    public OzelKagit() {
        super();
        this.isim = "OzelKagit";
        this.kalinlik = 2;
        this.tasSavunma *= kalinlik;
        this.makasSavunma *= kalinlik;
    }
    public OzelKagit(int dayanma, int seviyeP, int nuf, int kalin) {
        super(dayanma, seviyeP, nuf);
        this.isim = "OzelKagit";
        this.kalinlik = kalin;
        this.tasSavunma *= kalinlik;
        this.makasSavunma *= kalinlik;
    }
}
