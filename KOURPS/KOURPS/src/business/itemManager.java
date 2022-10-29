package business;

import items.Kagit;
import items.Makas;
import items.Nesneler;
import items.Tas;

public class itemManager
{
    public static double savas(Nesneler savasan1, Nesneler savasan2)
    {
        double savunma = 0;
        if (savasan2.getClass() == savasan1.getClass())
        {
            return 0;
        }
        if (savasan1 instanceof Kagit)
        {
            if (savasan2 instanceof Tas)
            {
                savunma = ((Tas) savasan2).kagitSavunma;
            }
            if(savasan2 instanceof Makas)
            {
                savunma = ((Makas) savasan2).kagitSavunma;
            }
        }
        else if (savasan1 instanceof Tas)
        {
            if (savasan2 instanceof Makas)
            {
                savunma = ((Makas) savasan2).tasSavunma;
            }
            if(savasan2 instanceof Kagit)
            {
                savunma = ((Kagit) savasan2).tasSavunma;
            }
        }
        else if (savasan1 instanceof Makas)
        {
            if (savasan2 instanceof Kagit)
            {
                savunma = ((Kagit) savasan2).makasSavunma;
            }
            if(savasan2 instanceof Tas)
            {
                savunma = ((Tas) savasan2).makasSavunma;
            }
        }
        System.out.println(savunma);
        return savunma;
    }

}
