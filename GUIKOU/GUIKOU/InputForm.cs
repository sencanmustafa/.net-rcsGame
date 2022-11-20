using Business;
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
    public partial class InputForm : Form
    {
        ItemManager itemManager;
        List<int> list = new List<int>();
        public InputForm()
        {
            InitializeComponent();
            this.itemManager = new ItemManager();
        }
        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            list.Add(itemManager.defineInstance(combo0.Text));
            list.Add(itemManager.defineInstance(combo1.Text));
            list.Add(itemManager.defineInstance(combo2.Text));
            list.Add(itemManager.defineInstance(combo3.Text));
            list.Add(itemManager.defineInstance(combo4.Text));
            PlayervsAIForm _form = new PlayervsAIForm(list);
            _form.ShowDialog();

        }
    }
}
