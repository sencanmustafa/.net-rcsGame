package items;

public class Tas extends Nesneler {
    // Değişkenler

    public int katilik;
    
    public double makasSavunma;
    public double kagitSavunma;

    // Fonksiyonlar
    @Override
    public void nesneOzellikleriGoster() {
        super.nesneOzellikleriGoster();
        System.out.println("Katılık: " + katilik);
    }

    public double etkiHesapla(double rakipSavunmasi)
    {
        return katilik / rakipSavunmasi;
    }

    @Override
    public void durumGuncelle(double etki)
    {
        super.durumGuncelle(etki);
    }

    // Constructorlar
    public Tas() {
        super();
        this.isim = "tas";
        this.katilik = 2;
        this.makasSavunma = 0.8 * this.katilik;
        this.kagitSavunma = 0.2 * this.katilik;
    }

    public Tas(int dayanma, int seviyeP, int kati)
    {
        super(dayanma, seviyeP);
        this.isim = "tas";
        this.katilik = kati;
        this.makasSavunma = 0.8 * this.katilik;
        this.kagitSavunma = 0.2 * this.katilik;
    }
}
