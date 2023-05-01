namespace parte029
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusLabel.Text = this.Size.Width + "x" + this.Size.Height;
            statusProgess.Value = 75;
        }

        private void zoom100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(600, 400);
        }

        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width - 20, this.Size.Height - 20);
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width + 20, this.Size.Height + 20);
        }

        private void nOVOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}