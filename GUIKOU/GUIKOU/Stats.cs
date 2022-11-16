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
    public partial class Stats : Form
    {
        public Stats(string isim, double dayaniklilik)
        {
            InitializeComponent();
         
            dayaniklilikData.Text = dayaniklilik.ToString();
        }
        public Stats()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
