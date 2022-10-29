package items;

public class Makas extends Nesneler {
    // Değişkenler

    public int keskinlik;
    public double tasSavunma;
    public double kagitSavunma;

    // Fonksiyonlar
    @Override
    public void nesneOzellikleriGoster()
    {
        super.nesneOzellikleriGoster();
        System.out.println("Keskinlik: " + keskinlik);
    }

    public double etkiHesapla(double rakipSavunmasi)
    {
        return keskinlik / rakipSavunmasi;
    }

    @Override
    public void durumGuncelle(double etki)
    {
        super.durumGuncelle(etki);
    }

    // Constructorlar
    public Makas() {
        super();
        this.isim = "makas";
        this.keskinlik = 2;
        this.tasSavunma = 0.2 * keskinlik;
        this.kagitSavunma = 0.8 * keskinlik;
    }

    public Makas(int dayanma, int seviyeP, int keskin) {
        super(dayanma, seviyeP);
        this.isim = "makas";
        this.keskinlik = keskin;
        this.tasSavunma = 0.2 * keskinlik;
        this.kagitSavunma = 0.8 * keskinlik;
    }
}
