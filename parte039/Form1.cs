namespace parte039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
 
            if(colorDialog.ShowDialog() != DialogResult.Cancel)
            {
                lblColor.BackColor = colorDialog.Color;
                btnCor.BackColor = colorDialog.Color;
            }

        }
    }
}