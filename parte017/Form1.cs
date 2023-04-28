namespace parte017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (txt.Text == "Henrique")
            {
                MessageBox.Show("Você digitou seu Nome !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt.ZoomFactor > 0)
            {
                txt.ZoomFactor--;
            }
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt.ZoomFactor++;
        }
    }
}