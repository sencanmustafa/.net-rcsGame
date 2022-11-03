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
        public PlayervsAIForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nesne1_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            stat.Show();
        }

        private void nesne2_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            stat.Show();
        }

        private void nesne3_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            stat.Show();
        }

        private void nesne4_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            stat.Show();
        }

        private void nesne5_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            stat.Show();
        }
    }
}
