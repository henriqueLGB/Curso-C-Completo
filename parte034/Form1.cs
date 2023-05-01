namespace parte034
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog.PageSettings    = new System.Drawing.Printing.PageSettings();
            pageSetupDialog.PrinterSettings = new System.Drawing.Printing.PrinterSettings();

            pageSetupDialog.ShowDialog();
        }
    }
}