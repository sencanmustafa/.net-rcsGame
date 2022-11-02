// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;
using Business;
using Entities.objects;
using Entities.user;

namespace ConsoleUI
{
    class Program
    {
        static void Main(String[] args)
        {
            ItemManager itemManager = new ItemManager();

            while (true)
            {
                Console.WriteLine("1 -> Bilgisayar-Bilgisayar");
                Console.WriteLine("2 -> Kullacini-Bilgisayar");
                Console.WriteLine("9 -> cikis");

                Console.WriteLine("bir secim yapiniz");
                int secim = Convert.ToInt32(Console.ReadLine()); ;
                if (secim == 9)
                {
                    break;
                }
                else if (secim == 1)
                {
                    
                    Bilgisayar bilgisayar = new Bilgisayar(1, "bilgisayar");
                    Bilgisayar bilgisayar2 = new Bilgisayar(2, "bilgisayar2");
                    itemManager.nesneUret(bilgisayar.nesneListesi);
                    itemManager.nesneUret(bilgisayar2.nesneListesi);
                    int hamleSayisi = 0;
                    while (true)
                    {
                        if (bilgisayar2.nesneListesi.Count == 0)
                        {
                            Console.WriteLine("Oyun bitmistir Oyunu bilgisayar 1 kazandi");
                            break;
                        }
                        if (bilgisayar.nesneListesi.Count == 0)
                        {
                            Console.WriteLine("Oyun bitmistir oyunu bilgisayar 2 kazandi");
                            break;
                        }
                        Console.WriteLine("2 -> savastir");
                        Console.WriteLine("3 -> bilgisayar 1 nesneleri gor");
                        Console.WriteLine("4 -> bilgisayar 2 nesneleri gor");
                        Console.WriteLine("9 -> ust menu");
                        Console.WriteLine("bir secim yapiniz");
                        int secim2 = Convert.ToInt32(Console.ReadLine()); ;
                        if (secim2 == 2)
                        {
                            hamleSayisi++;
                        }
                        if (secim2 == 9)
                        {
                            break;
                        }

                        else if (secim2 == 2)
                        {
                            if (hamleSayisi == 10)
                            {
                                Console.WriteLine("*******************************************");
                                Console.WriteLine("Oyun max hamleye ulasmistir");
                                Console.WriteLine("*******************************************");
                                break;
                            }
                            int size;
                            int size2;
                            int kucuk;
                            size = bilgisayar.nesneListesi.Count();
                            size2 = bilgisayar2.nesneListesi.Count();
                            if (size>size2)
                            {
                                kucuk = size2;
                            }
                            else
                            {
                                kucuk = size;
                            }
                            for (int i = 0; i < kucuk; i++)
                            {
                                Nesneler savasan1 = bilgisayar.nesneListesi[i];
                                Nesneler savasan2 = bilgisayar2.nesneListesi[i];
                                Console.WriteLine(savasan2.GetType());
                                Console.WriteLine(savasan1.GetType());
                                double savasan1etki = savasan1.etkiHesapla(itemManager.savas(savasan1, savasan2));
                                Console.WriteLine("sav1 etki " + savasan1etki);
                                double savasan2etki = savasan2.etkiHesapla(itemManager.savas(savasan2, savasan1));
                                Console.WriteLine("sav2 etki " + savasan2etki);
                                if (Double.IsInfinity(savasan1etki) || Double.IsInfinity(savasan2etki))
                                {
                                    Console.WriteLine("berabere");
                                    continue;
                                }

                                savasan1.nesneOzellikleriGoster();
                                savasan2.nesneOzellikleriGoster();
                                savasan1.durumGuncelle(savasan2etki);
                                savasan2.durumGuncelle(savasan1etki);
                                if (savasan1.dayaniklilik <= 0)
                                {
                                    bilgisayar.nesneListesi.Remove(savasan1);
                                    savasan2.seviyePuani += 20;
                                    if (savasan2.seviyePuani >= 30)
                                    {
                                        Console.WriteLine(savasan2.isim + "30 u asti");
                                    }
                                    break;
                                }

                                if (savasan2.dayaniklilik <= 0)
                                {
                                    bilgisayar2.nesneListesi.Remove(savasan2);
                                    savasan1.seviyePuani += 20;
                                    if (savasan1.seviyePuani >= 30)
                                    {
                                        Console.WriteLine(savasan1.isim + "30 u asti");
                                    }
                                    break;
                                }
                                savasan1.nesneOzellikleriGoster();
                                savasan2.nesneOzellikleriGoster();
                            }
                        }
                        else if (secim2 == 3)
                        {
                            bilgisayar.nesneleriGoruntule(bilgisayar.nesneListesi);
                        }
                        else if (secim2 == 4)
                        {
                            bilgisayar2.nesneleriGoruntule(bilgisayar2.nesneListesi);
                        }
                        else
                        {
                            Console.WriteLine("hatali secim ust menu");
                        }

                    }
                }
            }
        }

    }
}

