namespace parte041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFont_Click(object sender, EventArgs e)
        {
            if (font.ShowDialog() != DialogResult.Cancel)
            {
                lblFont.Font = font.Font;
                lblFont.ForeColor = font.Color;
            }
        }

        private void font_Apply(object sender, EventArgs e)
        {
            lblFont.Font = font.Font;
            lblFont.ForeColor = font.Color;
        }
    }
}