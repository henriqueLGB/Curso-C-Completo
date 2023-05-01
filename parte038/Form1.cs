namespace parte038
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string txt = txtPrint.Text;
            Font fonte = new Font("Arial", 24, FontStyle.Regular);
            e.Graphics.DrawString(txt, fonte, Brushes.Black, 50, 50);
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}