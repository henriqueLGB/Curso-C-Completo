namespace parte027
{
    public partial class Form1 : Form
    {
        string txt;

        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt = textBox1.Text;
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt = textBox1.Text;
            textBox1.Text = "";
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt))
            {
                textBox2.Text = txt;
            }
        }
    }
}