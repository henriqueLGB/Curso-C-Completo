namespace parte014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox.BackgroundImage = Image.FromFile("img/fundo.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Image.FromFile("img/mage.jpg");
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Image.FromFile("img/imperador.jpg");
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Image.FromFile("img/mage2.jpg");
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}