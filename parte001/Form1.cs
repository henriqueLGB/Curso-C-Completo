namespace parte001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao C# !");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.Orange;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.Red;
        }
    }
}