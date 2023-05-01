namespace parte024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picture.BackgroundImage = Image.FromFile("img/fundo.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picture.BackgroundImage = Image.FromFile("img/mage.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            picture.BackgroundImage = Image.FromFile("img/mage2.jpg");
        }
    }
}