namespace parte040
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folder.ShowDialog() != DialogResult.Cancel)
            {
                lblFolder.Text = folder.SelectedPath;
            }
        }
    }
}