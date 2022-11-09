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
        public AIvsAIForm()
        {
            InitializeComponent();
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

        private void nesne1_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
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
            Stats stat = new Stats();
            stat.ShowDialog();
        }

        private void aiNesne2_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            stat.ShowDialog();
        }

        private void aiNesne3_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            stat.ShowDialog();
        }

        private void aiNesne4_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            stat.ShowDialog();
        }

        private void aiNesne5_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            stat.ShowDialog();
        }
    }
}
