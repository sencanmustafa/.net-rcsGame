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
            PlayervsAIForm playervsAI = new PlayervsAIForm();
            this.Hide();
            playervsAI.Show();
        }

        private void AIvsAI_Click(object sender, EventArgs e)
        {
            AIvsAIForm AIvsAI = new AIvsAIForm();
            this.Hide();
            AIvsAI.Show();
        }
    }
}