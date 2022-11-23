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
    public partial class PlayervsAIForm : Form
    {

        Kullanici user;
        Bilgisayar bilgisayar;
        ItemManager itemManager;
        public List<int> recieveList;
        int hamleSayisi = 0;
        public PlayervsAIForm(List<int> inputList)
        {
            InitializeComponent();
            this.recieveList = inputList;
            this.bilgisayar = new Bilgisayar();
            this.user = new Kullanici();
            this.itemManager = new ItemManager();
            itemManager.NesneUret(bilgisayar.nesneListesi);
            itemManager.selectObject(recieveList, user.nesneListesi);

        }
        public void savas(Nesneler userSavasan)
        {
            int userListSizeExceptNull = 0;
            for (int i = 0; i < user.nesneListesi.Count; i++)
            {
                if (user.nesneListesi[i]!=null)
                {
                    userListSizeExceptNull += 1;
                }
            }
            if (user.nesneListesi.Count == 0)
            {
                MessageBox.Show("Oyun bitmistir Oyunu bilgisayar 1 kazandi");
                return;
            }
            if (bilgisayar.nesneListesi.Count == 0)
            {
                MessageBox.Show("Oyun bitmistir oyunu user kazandi");
                Application.Exit();
            }

            hamleSayisi++;
            if (hamleSayisi == 30)
            {
                MessageBox.Show("Oyun max hamleye ulasmistir");
                if (bilgisayar.nesneListesi.Count > userListSizeExceptNull)
                {
                    MessageBox.Show("Oyunu bilgisayar  kazanmistir");
                }
                else
                {
                    MessageBox.Show("oyunu user kazanmistir");
                }
                return;
            }
            int size;
            int size2;
            int kucuk;
            size = bilgisayar.nesneListesi.Count();
            size2 = user.nesneListesi.Count();
            if (size > size2)
            {
                kucuk = size2;
            }
            else
            {
                kucuk = size;
            }
            /*
            for (int i = 0; i < kucuk; i++)
            {
                Nesneler savasan1 = bilgisayar.nesneListesi[i];
                aiOynanan.Text = savasan1.isim.ToString();
                Nesneler savasan2 = userSavasan;
                oynanan.Text = savasan2.isim.ToString();
                double savasan1etki = savasan1.etkiHesapla(itemManager.savas(savasan1, savasan2));
                double savasan2etki = savasan2.etkiHesapla(itemManager.savas(savasan2, savasan1));
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
                savasan2.selected= true;
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
                    user.nesneListesi.Remove(savasan2);
                    break;
                }
                if (savasan2.seviyePuani >= 30)
                {
                    user.nesneListesi.Add(itemManager.returnSpecialObject(savasan2));
                    user.nesneListesi.Remove(savasan2);
                }
                if (hamleSayisi==5)
                {
                    for (int x = 0; x < user.nesneListesi.Count; x++)
                    {
                        user.nesneListesi[x].selected = false;

                    }
                    userItem0.Enabled = true;
                    userItem1.Enabled = true;
                    userItem2.Enabled = true;
                    userItem3.Enabled = true;
                    userItem4.Enabled = true;
                }
            }
            */
            Nesneler savasan1 = itemManager.returnRandomObject(bilgisayar.nesneListesi);
            aiOynanan.Text = savasan1.isim.ToString();
            Nesneler savasan2 = userSavasan;
            if (savasan2 == null || savasan1==null)
            {
                return;
            }
            oynanan.Text = savasan2.isim.ToString();
            double savasan1etki = savasan1.etkiHesapla(itemManager.savas(savasan1, savasan2));
            double savasan2etki = savasan2.etkiHesapla(itemManager.savas(savasan2, savasan1));
            if (Double.IsInfinity(savasan1etki) || Double.IsInfinity(savasan2etki))
            {
                savasan2.selected = true;
                return;
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
            savasan2.selected = true;
            if (savasan1.dayaniklilik <= 0)
            {
                bilgisayar.nesneListesi.Remove(savasan1);

                
            }
            if (savasan1.seviyePuani >= 30)
            {
                bilgisayar.nesneListesi.Add(itemManager.returnSpecialObject(savasan1));
                bilgisayar.nesneListesi.Remove(savasan1);
            }
            if (savasan2.dayaniklilik <= 0)
            {
                int savasan2Index = user.nesneListesi.IndexOf(savasan2);
                user.nesneListesi[savasan2Index] = null;
                var item = user.nesneListesi[0];
            }
            if (savasan2.seviyePuani >= 30)
            {
                user.nesneListesi.Add(itemManager.returnSpecialObject(savasan2));
                user.nesneListesi.Remove(savasan2);
            }
            if (hamleSayisi == 5)
            {
                for (int x = 0; x < user.nesneListesi.Count; x++)
                {
                    user.nesneListesi[x].selected = false;

                }
                userItem0.Enabled = true;
                userItem1.Enabled = true;
                userItem2.Enabled = true;
                userItem3.Enabled = true;
                userItem4.Enabled = true;
            }
        }

        public void refreshLabels()
        {
            if (hamleSayisi>=5)
            {
                userItem0.Enabled = user.nesneListesi[0] != null ? true : false;
                userItem1.Enabled = user.nesneListesi[1] != null ? true : false;
                userItem2.Enabled = user.nesneListesi[2] != null ? true : false;
                userItem3.Enabled = user.nesneListesi[3] != null ? true : false;
                userItem4.Enabled = user.nesneListesi[4] != null ? true : false;
            }
            try
            {
                aiNesne1.Text = bilgisayar.nesneListesi[0].isim;
            }
            catch
            {
                aiNesne1.Text = "";
            }

            try
            {
                aiNesne2.Text = bilgisayar.nesneListesi[1].isim;
            }
            catch
            {

                aiNesne2.Text = "";
            }
            try
            {
                aiNesne3.Text = bilgisayar.nesneListesi[2].isim;
            }
            catch
            {

                aiNesne3.Text = "";
            }
            try
            {
                aiNesne4.Text = bilgisayar.nesneListesi[3].isim;

            }
            catch
            {

                aiNesne4.Text = "";
            }
            try
            {
                aiNesne5.Text = bilgisayar.nesneListesi[4].isim;
            }
            catch
            {

                aiNesne5.Text = "";
            }
            try
            {
                nesne1.Text = user.nesneListesi[0].isim;
            }
            catch
            {
                nesne1.Text = "";
            }

            try
            {
                nesne2.Text = user.nesneListesi[1].isim;
            }
            catch
            {

                nesne2.Text = "";
            }
            try
            {
                nesne3.Text = user.nesneListesi[2].isim;
            }
            catch
            {

                nesne3.Text = "";
            }
            try
            {
                nesne4.Text = user.nesneListesi[3].isim;

            }
            catch
            {

                nesne4.Text = "";
            }
            try
            {
                nesne5.Text = user.nesneListesi[4].isim;
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

        private void nesne1_Click(object sender, EventArgs e)
        {
            try
            {

                Stats stat = new Stats(user.nesneListesi[0].isim, user.nesneListesi[0].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                return;
            }
        }

        private void nesne2_Click(object sender, EventArgs e)
        {
            try
            {

                Stats stat = new Stats(user.nesneListesi[1].isim, user.nesneListesi[1].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                return;
            }
        }

        private void nesne3_Click(object sender, EventArgs e)
        {
            try
            {

                Stats stat = new Stats(user.nesneListesi[2].isim, user.nesneListesi[2].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                return;
            }
        }

        private void nesne4_Click(object sender, EventArgs e)
        {
            try
            {

                Stats stat = new Stats(user.nesneListesi[3].isim, user.nesneListesi[3].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                return;
            }
        }

        private void nesne5_Click(object sender, EventArgs e)
        {
            try
            {

                Stats stat = new Stats(user.nesneListesi[4].isim, user.nesneListesi[4].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                return;
            }
        }

        private void PlayervsAIForm_Load(object sender, EventArgs e)
        {
            refreshLabels();
        }

        private void aiNesne1_Click(object sender, EventArgs e)
        {
            try
            {

                Stats stat = new Stats(bilgisayar.nesneListesi[0].isim, bilgisayar.nesneListesi[0].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                return;
            }
        }

        private void aiNesne2_Click(object sender, EventArgs e)
        {
            try
            {

                Stats stat = new Stats(bilgisayar.nesneListesi[1].isim, bilgisayar.nesneListesi[1].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                return;
            }
        }

        private void aiNesne3_Click(object sender, EventArgs e)
        {
            try
            {

                Stats stat = new Stats(bilgisayar.nesneListesi[2].isim, bilgisayar.nesneListesi[2].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                return;
            }
        }

        private void aiNesne4_Click(object sender, EventArgs e)
        {
            try
            {

                Stats stat = new Stats(bilgisayar.nesneListesi[3].isim, bilgisayar.nesneListesi[3].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                return;
            }
        }

        private void aiNesne5_Click(object sender, EventArgs e)
        {
            try
            {

                Stats stat = new Stats(bilgisayar.nesneListesi[4].isim, bilgisayar.nesneListesi[4].dayaniklilik);
                stat.ShowDialog();
            }
            catch (Exception)
            {
                Stats stat = new Stats();
                stat.ShowDialog();
                return;
            }
        }

        private void fight_Click(object sender, EventArgs e)
        {
            
            savas(user.nesneListesi[0]);
            refreshLabels();
            return;
        }

        private void denemeButton_Click(object sender, EventArgs e)
        {
            savas(user.nesneListesi[0]);
            denemeButton.Enabled = false;
            refreshLabels();
        }

        private void userItem0_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.nesneListesi[0] == null)
                {
                    userItem0.Enabled = false;
                    refreshLabels();
                    return;
                }
                savas(user.nesneListesi[0]);
                if (user.nesneListesi[0] == null)
                {
                    userItem0.Enabled = false;
                    refreshLabels();
                    return;
                }
                if (user.nesneListesi[0].selected == true && hamleSayisi < 5)
                {
                    userItem0.Enabled = false;
                }
                refreshLabels();
            }
            catch (Exception)
            {
                
                return;
            }
            
        }

        private void userItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.nesneListesi[1] == null)
                {
                    userItem1.Enabled = false;
                    refreshLabels();
                    return;
                }
                savas(user.nesneListesi[1]);
                if (user.nesneListesi[1] == null)
                {
                    userItem1.Enabled = false;
                    refreshLabels();
                    return;
                }
                if (user.nesneListesi[1].selected == true && hamleSayisi<5)
                {
                    userItem1.Enabled = false;
                }
                refreshLabels();
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void userItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.nesneListesi[2] == null)
                {
                    userItem2.Enabled = false;
                    refreshLabels();
                    return;
                }
                savas(user.nesneListesi[2]);
                if (user.nesneListesi[2] == null)
                {
                    userItem2.Enabled = false;
                    refreshLabels();
                    return;
                }
                if (user.nesneListesi[2].selected == true && hamleSayisi < 5)
                {
                    userItem2.Enabled = false;
                }
                refreshLabels();
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void userItem3_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.nesneListesi[3] == null)
                {
                    userItem3.Enabled = false;
                    refreshLabels();
                    return;
                }
               
                savas(user.nesneListesi[3]);
                if (user.nesneListesi[3] == null)
                {
                    userItem3.Enabled = false;
                    refreshLabels();
                    return;
                }
                if (user.nesneListesi[3].selected == true && hamleSayisi < 5)
                {
                    userItem3.Enabled = false;
                }
                refreshLabels();
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void userItem4_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.nesneListesi[4].selected == true)
                {
                    userItem4.Enabled = false;
                }
                savas(user.nesneListesi[4]);
                if (user.nesneListesi[4].selected == true)
                {
                    userItem4.Enabled = false;
                }
                if (user.nesneListesi[4].selected == true && hamleSayisi < 5)
                {
                    userItem4.Enabled = false;
                }
                refreshLabels();
            }
            catch (Exception)
            {

                return;
            }
            
        }
    }
}
