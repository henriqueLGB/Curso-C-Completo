namespace parte013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value % 2 == 0)
            {
                label1.Text = numericUpDown1.Value.ToString();
            }
        }
    }
}