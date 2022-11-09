using System;
using System.Threading.Tasks;
using Entities.objects;

namespace Business
{
    public class ItemManager
    {
        public Nesneler returnNesne(int secim)
        {
            if (secim == 1)
            {
                return new Tas();
            }
            else if (secim == 2)
            {
                return new Makas();
            }
            else
            {
                return new Kagit();
            }
        }

        public double savas(Nesneler savasan1, Nesneler savasan2)
        {
            double savunma = 0;
            if (savasan2.GetType() == savasan1.GetType())
            {
                return 0;
            }
            if (savasan1 is Kagit)
            {
                if (savasan2 is Tas)
                {
                    savunma = ((Tas)savasan2).kagitSavunma;
                }
                if (savasan2 is Makas)
                {
                    savunma = ((Makas)savasan2).kagitSavunma;
                }
            }
            else if (savasan1 is Tas)
            {
                if (savasan2 is Makas)
                {
                    savunma = ((Makas)savasan2).tasSavunma;
                }
                if (savasan2 is Kagit)
                {
                    savunma = ((Kagit)savasan2).tasSavunma;
                }
            }
            else if (savasan1 is Makas)
            {
                if (savasan2 is Kagit)
                {
                    savunma = ((Kagit)savasan2).makasSavunma;
                }
                if (savasan2 is Tas)
                {
                    savunma = ((Tas)savasan2).makasSavunma;
                }
            }
            Console.WriteLine(savunma);
            return savunma;
        }





        public void bilgisayarNesneUret(List<Nesneler> list)
        {

            for (int j = 0; j < 5; j++)
            {
                Random r = new Random();
                int randomInt = r.Next(3);

                if (randomInt == 0)
                {
                    list.Add(new Tas());
                }
                else if (randomInt == 1)
                {
                    list.Add(new Makas());
                }
                else
                {
                    list.Add(new Kagit());
                }
            }
        }

        public void userNesneUret(List<Nesneler> list,int secim1,int secim2)
        {
            list.Add(new Tas());
            list.Add(new Kagit());
            list.Add(new Makas());
            list.Add(returnNesne(secim1));
            list.Add(returnNesne(secim2));
        
        }

    }
}

