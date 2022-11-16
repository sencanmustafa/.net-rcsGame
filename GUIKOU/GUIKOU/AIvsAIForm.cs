using Business;
using Entities.objects;
using Entities.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIKOU
{
    public partial class AIvsAIForm : Form
    {
        Bilgisayar bilgisayar;
        Bilgisayar bilgisayar2;
        ItemManager manager;
        int hamleSayisi = 0;


        public AIvsAIForm()
        {
            InitializeComponent();
            this.bilgisayar = new Bilgisayar(1, "bilgisayar1");
            this.bilgisayar2 = new Bilgisayar(2, "bilgisayar2");
            this.manager = new ItemManager();
            manager.NesneUret(bilgisayar.nesneListesi);
            int locationValue = 150;
            //manager.NesneUret(bilgisayar.nesneListesi);
            foreach (var item in bilgisayar.nesneListesi)
            {
                Label lbl = new Label();
                lbl.Tag = item;
                lbl.Text = item.isim.ToString();
                lbl.Location = new Point(locationValue, 50);
                locationValue += 100;
                
            }
            manager.NesneUret(bilgisayar2.nesneListesi);
            nesne1.Text = bilgisayar.nesneListesi[0].isim;
            

        }

        public void savas()
        {
                if (bilgisayar2.nesneListesi.Count == 0)
                {
                    MessageBox.Show("Oyun bitmistir Oyunu bilgisayar 1 kazandi");
                    return;
                }
                if (bilgisayar.nesneListesi.Count == 0)
                {
                    MessageBox.Show("Oyun bitmistir oyunu bilgisayar 2 kazandi");
                    return;
                }
    
                hamleSayisi++;
                    if (hamleSayisi == 30)
                    {
                        MessageBox.Show("Oyun max hamleye ulasmistir");
                        if (bilgisayar.nesneListesi.Count > bilgisayar2.nesneListesi.Count)
                        {
                            MessageBox.Show("Oyunu bilgisayar1  kazanmistir");
                        }
                        else
                        {
                            MessageBox.Show("oyunu bilgisayar2 kazanmistir");
                        }
                        return;
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
                        oynanan1.Text = savasan1.isim.ToString();
                        Nesneler savasan2 = bilgisayar2.nesneListesi[i];
                        oynanan2.Text = savasan2.isim.ToString();
                        double savasan1etki = savasan1.etkiHesapla(manager.savas(savasan1, savasan2));                   
                        double savasan2etki = savasan2.etkiHesapla(manager.savas(savasan2, savasan1));                      
                        if (Double.IsInfinity(savasan1etki) || Double.IsInfinity(savasan2etki))
                        {
                            
                            continue;
                        }
                        if (savasan1etki > savasan2etki)
                        {
                            savasan1.seviyePuani += 20;

                        }
                        if (savasan2etki > savasan1etki)
                        {
                            savasan2.seviyePuani += 20;
                        }
                     
                        savasan1.durumGuncelle(savasan2etki);
                        savasan2.durumGuncelle(savasan1etki);
                        if (savasan1.dayaniklilik <= 0)
                        {
                            bilgisayar.nesneListesi.Remove(savasan1);

                            break;
                        }
                        if (savasan1.seviyePuani >= 30)
                        {
                            bilgisayar.nesneListesi.Add(manager.returnSpecialObject(savasan1));
                            bilgisayar.nesneListesi.Remove(savasan1);
                        }
                        if (savasan2.dayaniklilik <= 0)
                        {
                            bilgisayar2.nesneListesi.Remove(savasan2);
                            break;
                        }
                        if (savasan2.seviyePuani >= 30)
                        {
                            bilgisayar2.nesneListesi.Add(manager.returnSpecialObject(savasan2));
                            bilgisayar2.nesneListesi.Remove(savasan2);
                        }
                        
                    }
        }
        
        public void refreshLabels()
        {
            try
            {
                aiNesne1.Text = bilgisayar2.nesneListesi[0].isim;
            }
            catch
            {
                aiNesne1.Text = "";
            }

            try
            {
                aiNesne2.Text = bilgisayar2.nesneListesi[1].isim;
            }
            catch 
            {

                aiNesne2.Text = "";
            }
            try
            {
                aiNesne3.Text = bilgisayar2.nesneListesi[2].isim;
            }
            catch 
            {

                aiNesne3.Text = "";
            }
            try
            {
                aiNesne4.Text = bilgisayar2.nesneListesi[3].isim;

            }
            catch 
            {

                aiNesne4.Text = "";
            }
            try
            {
                aiNesne5.Text = bilgisayar2.nesneListesi[4].isim;
            }
            catch 
            {

                aiNesne5.Text = "";
            }
            try
            {
                nesne1.Text = bilgisayar.nesneListesi[0].isim;
            }
            catch
            {
                nesne1.Text = "";
            }

            try
            {
                nesne2.Text = bilgisayar.nesneListesi[1].isim;
            }
            catch
            {

                nesne2.Text = "";
            }
            try
            {
                nesne3.Text = bilgisayar.nesneListesi[2].isim;
            }
            catch
            {

                nesne3.Text = "";
            }
            try
            {
                nesne4.Text = bilgisayar.nesneListesi[3].isim;

            }
            catch
            {

                nesne4.Text = "";
            }
            try
            {
                nesne5.Text = bilgisayar.nesneListesi[4].isim;
            }
            catch
            {

                nesne5.Text = "";
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            stat.ShowDialog();
        }

        private void nesne2_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            stat.ShowDialog();
        }
        private void nesne_Click(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            var a = lbl.Text;
            var nesne = (Nesneler)lbl.Tag;
            
            Stats stat = new Stats(bilgisayar.nesneListesi[0].isim, bilgisayar.nesneListesi[0].dayaniklilik);
            stat.ShowDialog();
        }


        private void nesne1_Click(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
         
            var nesne = (Nesneler)lbl.Tag;
            Stats stat = new Stats(nesne.isim, nesne.dayaniklilik);
            stat.ShowDialog();
        }

        private void nesne4_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            stat.ShowDialog();
        }

        private void nesne5_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            stat.ShowDialog();
        }

        private void aiNesne1_Click(object sender, EventArgs e)
        {
            try
            {

                Stats stat = new Stats(bilgisayar2.nesneListesi[0].isim, bilgisayar2.nesneListesi[0].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                throw;
            }
        }

        private void aiNesne2_Click(object sender, EventArgs e)
        {
            try
            {

                Stats stat = new Stats(bilgisayar2.nesneListesi[1].isim, bilgisayar2.nesneListesi[1].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                throw;
            }
        }

        private void aiNesne3_Click(object sender, EventArgs e)
        {
            try
            {

                Stats stat = new Stats(bilgisayar2.nesneListesi[2].isim, bilgisayar2.nesneListesi[2].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                throw;
            }
        }

        private void aiNesne4_Click(object sender, EventArgs e)
        {
            try
            {
                
                Stats stat = new Stats(bilgisayar2.nesneListesi[3].isim,bilgisayar2.nesneListesi[3].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                throw;
            }
            
        }

        private void aiNesne5_Click(object sender, EventArgs e)
        {
            try
            {

                Stats stat = new Stats(bilgisayar2.nesneListesi[4].isim, bilgisayar2.nesneListesi[4].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                throw;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AIvsAIForm_Load(object sender, EventArgs e)
        {
            refreshLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            savas();
            refreshLabels();
           
            return;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
