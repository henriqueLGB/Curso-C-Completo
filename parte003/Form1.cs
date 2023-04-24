namespace parte003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbTitulo.Text = textBox1.Text;  
        }
    }
}