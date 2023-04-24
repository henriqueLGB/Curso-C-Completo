namespace parte005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check01_CheckedChanged(object sender, EventArgs e)
        {
            string nome = check01.Text;
            bool status = check01.Checked;

            MessageBox.Show(nome + " " + status);
        }

        private void check02_CheckedChanged(object sender, EventArgs e)
        {
            string nome = check02.Text;
            bool status = check02.Checked;

            MessageBox.Show(nome + " " + status);
        }

        private void check03_CheckedChanged(object sender, EventArgs e)
        {
            string nome = check03.Text;
            bool status = check03.Checked;

            MessageBox.Show(nome + " " + status);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checados = "";

            if (check01.Checked)
            {
                checados += check01.Text + " - ";
            }

            if (check02.Checked)
            {
                checados += check02.Text + " - ";
            }

            if (check03.Checked)
            {
                checados += check03.Text;
            }

            MessageBox.Show(checados);
        }
    }
}