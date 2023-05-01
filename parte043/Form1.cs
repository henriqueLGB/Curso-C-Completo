namespace parte043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            save.Filter = "text| *.txt | PDF | *.pdf";

            if(save.ShowDialog() != DialogResult.Cancel)
            {
                label1.Text = save.FileName;
            }
        }
    }
}