// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;
using Business;
using Entities.objects;
using Entities.user;

namespace ConsoleUI
{
    class Program
    {
        static  void Main(String[] args)
        {
            ItemManager itemManager = new ItemManager();

            while (true)
            {
                 Console.WriteLine("1 -> Bilgisayar-Bilgisayar");
                Console.WriteLine("2 -> Kullacini-Bilgisayar");
                Console.WriteLine("9 -> cikis");

                Console.WriteLine("bir secim yapiniz");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 9)
                {
                    break;
                }
                else if (secim == 1)
                {
                    
                    Bilgisayar bilgisayar = new Bilgisayar(1, "bilgisayar");
                    Bilgisayar bilgisayar2 = new Bilgisayar(2, "bilgisayar2");
                    itemManager.NesneUret(bilgisayar.nesneListesi);
                    itemManager.NesneUret(bilgisayar2.nesneListesi);
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
                            if (hamleSayisi == 30)
                            {
                                Console.WriteLine("*******************************************");
                                Console.WriteLine("Oyun max hamleye ulasmistir");
                                Console.WriteLine("*******************************************");
                                if (bilgisayar.nesneListesi.Count > bilgisayar2.nesneListesi.Count)
                                {
                                    Console.WriteLine("Oyunu bilgisayar  kazanmistir");
                                }
                                else
                                {
                                    Console.WriteLine("oyunu bilgisayar2 kazanmistir");
                                }
                                break;
                            }
                            int size;
                            int size2;
                            int kucuk;
                            size = bilgisayar.nesneListesi.Count();
                            size2 = bilgisayar2.nesneListesi.Count();
                            if (size > size2)
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
                                if (savasan1etki>savasan2etki)
                                {
                                    savasan1.seviyePuani += 20;
                                    
                                }
                                if (savasan2etki>savasan1etki)
                                {
                                    savasan2.seviyePuani += 20;
                                }
                                savasan1.nesneOzellikleriGoster();
                                savasan2.nesneOzellikleriGoster();
                                savasan1.durumGuncelle(savasan2etki);
                                savasan2.durumGuncelle(savasan1etki); 
                                if (savasan1.dayaniklilik <= 0)
                                {
                                    bilgisayar.nesneListesi.Remove(savasan1);
                                    
                                    break;
                                }
                                if (savasan1.seviyePuani >= 30)
                                {
                                    bilgisayar.nesneListesi.Add(itemManager.returnSpecialObject(savasan1));
                                    bilgisayar.nesneListesi.Remove(savasan1);
                                }
                                if (savasan2.dayaniklilik <= 0)
                                {
                                    bilgisayar2.nesneListesi.Remove(savasan2);
                                    break;
                                }
                                if (savasan2.seviyePuani>=30)
                                {
                                    bilgisayar2.nesneListesi.Add(itemManager.returnSpecialObject(savasan2));
                                    bilgisayar2.nesneListesi.Remove(savasan2);
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
                else if (secim == 2)
                {

                    Kullanici user1 = new Kullanici(1, "user1");
                    Bilgisayar bilgisayar = new Bilgisayar(1, "bilgisayar");

                   
                    itemManager.NesneUret(user1.nesneListesi);
                    itemManager.NesneUret(bilgisayar.nesneListesi);
                    int hamleSayisi = 0;
                    while (true)
                    {
                        if (user1.nesneListesi.Count == 0)
                        {
                            Console.WriteLine("Oyun bitmistir Oyunu bilgisayar 1 kazandi");
                            break;
                        }
                        if (bilgisayar.nesneListesi.Count == 0)
                        {
                            Console.WriteLine("Oyun bitmistir oyunu bilgisayar 2 kazandi");
                            break;
                        }
                        Console.WriteLine("*******************************************");
                        Console.WriteLine("2 -> savastir");
                        Console.WriteLine("3 -> user 1 nesneleri gor");
                        Console.WriteLine("4 -> bilgisayar  nesneleri gor");
                        Console.WriteLine("9 -> ust menu");
                        Console.WriteLine("bir secim yapiniz");
                        Console.WriteLine("*******************************************");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
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

                            if (hamleSayisi == 50)
                            {
                                Console.WriteLine("*******************************************");
                                Console.WriteLine("Oyun max hamleye ulasmistir");
                                Console.WriteLine("*******************************************");
                                if (user1.nesneListesi.Count > bilgisayar.nesneListesi.Count)
                                {
                                    Console.WriteLine("Oyunu user  kazanmistir");
                                }
                                else
                                {
                                    Console.WriteLine("oyunu bilgisayar kazanmistir");
                                }
                                break;
                            }
                            if (hamleSayisi == 5)
                            {
                                for (int i = 0; i < user1.nesneListesi.Count; i++)
                                {
                                    user1.nesneListesi[i].selected = false;
                                }
                            }

                            int size;
                            int size2;
                            int kucuk;
                            size = user1.nesneListesi.Count();
                            size2 = bilgisayar.nesneListesi.Count();
                            if (size > size2)
                            {
                                kucuk = size2;
                            }
                            else
                            {
                                kucuk = size;
                            }
                            goTo:
                            Console.WriteLine("Oynamak istediginiz objeyi secin");
                            int x = 0;
                            foreach (Nesneler item in user1.nesneListesi)
                            {

                                Console.WriteLine(x + " -> " + item.isim);
                                x++;
                            }
                            
                            int choose = Convert.ToInt32(Console.ReadLine());
                            if (user1.nesneListesi[choose].selected == true)
                            {
                                Console.WriteLine("bu nesne daha onceden secilmis lutfen farkli bir nesne seciniz...");
                                goto goTo;
                            }
                            if (hamleSayisi < 5)
                            {
                                user1.nesneListesi[choose].selected = true;
                            }
                            Nesneler savasan1 = user1.nesneListesi[choose];
                            Random r = new Random();
                            int randomInt = r.Next(size2);
                            Nesneler savasan2 = bilgisayar.nesneListesi[randomInt];
                                
                            double savasan1etki = savasan1.etkiHesapla(itemManager.savas(savasan1, savasan2));
                            
                            double savasan2etki = savasan2.etkiHesapla(itemManager.savas(savasan2, savasan1));
                            
                            if (Double.IsInfinity(savasan1etki) || Double.IsInfinity(savasan2etki))
                            {
                                Console.WriteLine("berabere");
                                continue;
                            }
                            if (savasan1etki > savasan2etki)
                            {
                                savasan1.seviyePuani += 20;

                            }
                            if (savasan2etki>savasan1etki)
                            {
                                savasan2.seviyePuani += 20;
                            }
                            savasan1.durumGuncelle(savasan2etki);
                            savasan2.durumGuncelle(savasan1etki);
                            if (savasan1.dayaniklilik <= 0)
                            {
                                user1.nesneListesi.Remove(savasan1);                                                           
                            }
                            if (savasan1.seviyePuani >= 30)
                            {
                                Console.WriteLine(savasan1.isim + " 30 puani asti ");
                                user1.nesneListesi.Add(itemManager.returnSpecialObject(savasan1));
                                user1.nesneListesi.Remove(savasan1);
                            }
                            if (savasan2.dayaniklilik <= 0)
                            {
                                bilgisayar.nesneListesi.Remove(savasan2);                             
                            }
                            if (savasan2.seviyePuani >= 30)
                            {
                                Console.WriteLine(savasan2.isim + " 30 puani asti ");
                                bilgisayar.nesneListesi.Add(itemManager.returnSpecialObject(savasan2));
                                bilgisayar.nesneListesi.Remove(savasan2);
                            }

                                Console.WriteLine("*******************************************");
                                savasan1.nesneOzellikleriGoster();
                                Console.WriteLine("*******************************************");
                                savasan2.nesneOzellikleriGoster();
                                Console.WriteLine("*******************************************");
                            }
                        
                        else if (secim2 == 3)
                        {
                            Console.WriteLine("*******************************************");
                            user1.nesneleriGoruntule(user1.nesneListesi);
                            Console.WriteLine("*******************************************");
                        }
                        else if (secim2 == 4)
                        {
                            Console.WriteLine("*******************************************");
                            bilgisayar.nesneleriGoruntule(bilgisayar.nesneListesi);
                            Console.WriteLine("*******************************************");
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
