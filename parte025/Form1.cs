namespace parte025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPesquisa1.Text))
            {
                IniBrowser1(txtPesquisa1.Text);
            }
            else
            {
                MessageBox.Show("Você deve digitar o link do site primeiro !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPesquisa2.Text))
            {
                IniBrowser2(txtPesquisa2.Text);
            }
            else
            {
                MessageBox.Show("Você deve digitar o link do site primeiro !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task Inicializar1()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        private async Task Inicializar2()
        {
            await webView22.EnsureCoreWebView2Async(null);
        }

        private async void IniBrowser1(string url)
        {
            await Inicializar1();
            webView21.CoreWebView2.Navigate("https://" + url);
        }

        private async void IniBrowser2(string url)
        {
            await Inicializar2();
            webView22.CoreWebView2.Navigate("https://" + url);
        }
    }
}