using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;

namespace parte020
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private async Task Inicializar()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPesquisa.Text))
            {
                IniBrowser(txtPesquisa.Text);
            }
            else
            {
                MessageBox.Show("Você deve digitar o link do site primeiro !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private async void IniBrowser(string url)
        {
            await Inicializar();
            webView21.CoreWebView2.Navigate("https://" + url);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(webView21 == null || webView21.CoreWebView2 == null)
            {
                MessageBox.Show("Você deve digitar o link do site primeiro !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (webView21.CoreWebView2.CanGoBack)
            {
                webView21.CoreWebView2.GoBack();
            }
        }

        private void btnGoForward_Click(object sender, EventArgs e)
        {
            if (webView21 == null || webView21.CoreWebView2 == null)
            {
                MessageBox.Show("Você deve digitar o link do site primeiro !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (webView21.CoreWebView2.CanGoForward)
            {
                webView21.CoreWebView2.GoForward();
            }
        }
    }
}