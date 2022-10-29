package items;

public class Kagit extends Nesneler {
    // Değişkenler

    public int nufuz;

    public double tasSavunma;
    public double makasSavunma;

    // Fonksiyonlar
    @Override
    public void nesneOzellikleriGoster() {
        super.nesneOzellikleriGoster();
        System.out.println("Nüfuz: " + nufuz);
    }

    public double etkiHesapla(double rakipSavunmasi) {
        return nufuz / rakipSavunmasi;
    }

    @Override
    public void durumGuncelle(double etki) {
        super.durumGuncelle(etki);
    }

    // Constructorlar
    public Kagit() {
        super();
        this.isim = "kagit";
        this.nufuz = 2;
        this.tasSavunma = 0.8 * nufuz;
        this.makasSavunma = 0.2 * nufuz;
    }

    public Kagit(int dayanma, int seviyeP, int nuf) {
        super(dayanma, seviyeP);
        this.isim = "kagit";
        this.nufuz = nuf;
        this.tasSavunma = 0.8 * nufuz;
        this.makasSavunma = 0.2 * nufuz;
    }
}
