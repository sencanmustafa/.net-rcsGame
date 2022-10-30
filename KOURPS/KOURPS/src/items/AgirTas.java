package items;

public class AgirTas extends Tas {
    // Değişkenler
    public String isim;
    public int sicaklik;

    // Fonksiyonlar
    @Override
    public void nesneOzellikleriGoster() {
        super.nesneOzellikleriGoster();
        System.out.println("Nesne Ismi : " + isim);
        System.out.println("Sıcaklık: " + sicaklik);
    }

    @Override
    public double etkiHesapla(double rakipSavunmasi)
    {
        return (katilik * sicaklik) / rakipSavunmasi;
    }

    @Override
    public void durumGuncelle(double etki) {
        super.durumGuncelle(etki);
    }

    // Constructorlar
    public AgirTas() {
        super();
        this.isim = "AgirTas";
        this.sicaklik = 2;
        this.makasSavunma *= this.sicaklik;
        this.kagitSavunma *= this.sicaklik;
    }

    public AgirTas(int dayanma, int seviyeP, int kati, int sicak) {
        super(dayanma, seviyeP, kati);
        this.isim = "AgirTas";
        this.sicaklik = sicak;
        this.makasSavunma *= this.sicaklik;
        this.kagitSavunma *= this.sicaklik;
    }
}
