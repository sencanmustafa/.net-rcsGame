package items;

public class UstaMakas extends Makas {
    // Değişkenler
    public String isim ;
    public int hiz;

    // Fonksiyonlar
    @Override
    public void nesneOzellikleriGoster() {
        super.nesneOzellikleriGoster();
        System.out.println("Nesne Ismi : " + isim);
        System.out.println("Hız: " + hiz);
    }

    @Override
    public double etkiHesapla(double rakipSavunmasi) {
        return hiz * keskinlik / rakipSavunmasi;
    }

    @Override
    public void durumGuncelle(double etki) {
        super.durumGuncelle(etki);
    }

    // Constructorlar
    public UstaMakas() {
        super();
        this.isim = "UstaMakas";
        this.hiz = 2;
        this.tasSavunma *= hiz;
        this.kagitSavunma *= hiz;
    }

    public UstaMakas(int dayanma, int seviyeP, int keskin, int surat) {
        super(dayanma, seviyeP, keskin);
        this.isim = "UstaMakas";
        this.hiz = surat;
        this.tasSavunma *= hiz;
        this.kagitSavunma *= hiz;
    }
}
