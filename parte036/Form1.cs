namespace parte036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() != DialogResult.Cancel)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string txt = richText.Text;
            Font letra = new Font("Arial", 20, FontStyle.Regular);
            Brush pincel = new SolidBrush(Color.Black);

            e.Graphics.DrawString(txt, letra, pincel, new PointF(20, 20));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PrinterSettings    = new System.Drawing.Printing.PrinterSettings();
            pageSetupDialog1.PageSettings       = new System.Drawing.Printing.PageSettings();
            if(pageSetupDialog1.ShowDialog() != DialogResult.Cancel)
            {
                printDocument.Print();
            }
        }
    }
}