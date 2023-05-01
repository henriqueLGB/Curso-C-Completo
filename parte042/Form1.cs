namespace parte042
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Imagem.png | *.png | Pdf | *.pdf";

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                //lblTexto.Text = openFileDialog1.FileName;

                foreach(var item in openFileDialog1.FileNames)
                {
                    listBox.Items.Add(item);
                }

            }
        }
    }
}