import items.Kagit;
import items.Makas;
import items.Nesneler;
import items.Tas;
import business.itemManager;
import java.sql.SQLOutput;
import java.util.*;

public class Oyun
{

    public static void nesneUret(List<Nesneler> list)
    {

        for (int j = 0;j<5;j++)
        {
            Random r = new Random();
            int randomInt = r.nextInt(3);

            if (randomInt == 0)
            {
                list.add(new Tas());
            }
            else if (randomInt == 1)
            {
                list.add(new Makas());
            }
            else {
                list.add(new Kagit());
            }
        }
    }
    public static void main(String[] args)
    {

        while (true)
        {
            System.out.println("1 -> Bilgisayar-Bilgisayar");
            System.out.println("2 -> Kullacini-Bilgisayar");
            System.out.println("9 -> cikis");
            Scanner scanner = new Scanner(System.in);
            System.out.println("bir secim yapiniz");
            int secim = scanner.nextInt();;
            if (secim==9)
            {
                break;
            }
            else if (secim==1)
            {

                Bilgisayar bilgisayar = new Bilgisayar(1,"bilgisayar");
                Bilgisayar bilgisayar2 = new Bilgisayar(2,"bilgisayar2");
                nesneUret(bilgisayar.nesneListesi);
                nesneUret(bilgisayar2.nesneListesi);
                while (true)
                {
                    System.out.println("2 -> savastir");
                    System.out.println("3 -> bilgisayar 1 nesneleri gor");
                    System.out.println("4 -> bilgisayar 2 nesneleri gor");
                    System.out.println("9 -> ust menu");
                    Scanner scanner2 = new Scanner(System.in);
                    System.out.println("bir secim yapiniz");
                    int secim2 = scanner.nextInt();;
                    if (secim2 == 9)
                    {
                        break;
                    }
                    else if (secim2==2)
                    {
                        for (int i =0;i<5;i++)
                        {
                            Nesneler savasan1 = bilgisayar.nesneListesi.get(i);
                            Nesneler savasan2 = bilgisayar2.nesneListesi.get(i);
                            System.out.println(savasan2.getClass());
                            System.out.println(savasan1.getClass());
                            double savasan1etki = savasan1.etkiHesapla(itemManager.savas(savasan1,savasan2));
                            System.out.println("sav1 etki " + savasan1etki);
                            double savasan2etki = savasan2.etkiHesapla(itemManager.savas(savasan2,savasan1));
                            System.out.println("sav2 etki " + savasan2etki);
                            if (Double.isInfinite(savasan1etki) || Double.isInfinite(savasan2etki))
                            {
                                System.out.println("berabere");
                                continue;
                            }

                            savasan1.nesneOzellikleriGoster();
                            savasan2.nesneOzellikleriGoster();
                            savasan1.durumGuncelle(savasan2etki);
                            savasan2.durumGuncelle(savasan1etki);
                            if (savasan1.dayaniklilik<=0)
                            {
                                bilgisayar.nesneListesi.remove(savasan1);
                                savasan2.seviyePuani += 20;
                                if (savasan2.seviyePuani >=30)
                                {
                                    System.out.println(savasan2.isim + "30 u asti");
                                }
                                break;
                            }

                            if (savasan2.dayaniklilik<=0)
                            {
                                bilgisayar2.nesneListesi.remove(savasan2);
                                savasan1.seviyePuani += 20;
                                if (savasan1.seviyePuani>=30)
                                {
                                    System.out.println(savasan1.isim + "30 u asti");
                                }
                                break;
                            }
                            savasan1.nesneOzellikleriGoster();
                            savasan2.nesneOzellikleriGoster();
                        }
                    }
                    else if (secim2==3)
                    {
                        bilgisayar.nesneleriGoruntule(bilgisayar.nesneListesi);
                    }
                    else if (secim2==4)
                    {
                        bilgisayar2.nesneleriGoruntule(bilgisayar2.nesneListesi);
                    }
                    else
                    {
                        System.out.println("hatali secim ust menu");
                    }

                }

                /*

                System.out.println("bilgisyar 1 nesneleri");
                bilgisayar.nesneleriGoruntule(bilgisayar.nesneListesi);
                System.out.println("bilgisyar 2 nesneleri");
                bilgisayar2.nesneleriGoruntule(bilgisayar2.nesneListesi);
                System.out.println("deneme");
                */

            }
        }

        /*
        Bilgisayar bilgisayar = new Bilgisayar(1,"bilgisayar");
        Kullanici user = new Kullanici(2,"user1");
        nesneUret(bilgisayar.nesneListesi);
        Makas makas = new Makas();
        Tas tas = new Tas();
        double tasEtki = tas.makasSavunma;
        //double makasEtki = makas.tasSavunma;
        double hasar = makas.etkiHesapla(tasEtki);
        makas.durumGuncelle(hasar);
        makas.nesneOzellikleriGoster();*/


    }
}





