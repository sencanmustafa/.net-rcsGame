namespace GUIKOU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayervsAI_Click(object sender, EventArgs e)
        {

            InputForm _form = new InputForm();
            this.Hide();
            _form.Show();
        }

        private void AIvsAI_Click(object sender, EventArgs e)
        {
            AIvsAIForm AIvsAI = new AIvsAIForm();
            this.Hide();
            AIvsAI.Show();
        }
    }
}