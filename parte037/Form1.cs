namespace parte037
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string txt = txtPrint.Text;
            Font fonte = new Font("Arial", 24, FontStyle.Bold);
            e.Graphics.DrawString(txt, fonte, Brushes.Black, 50, 50);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            printReview.Document = printDocument;
        }

        private void btnImprir_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }
    }
}