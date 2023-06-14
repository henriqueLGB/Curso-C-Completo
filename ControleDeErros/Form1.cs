namespace ControleDeErros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            try
            {

                int[] num = { 10, 20, 30, 40, 50 };

                string res = "";

                for(int i = 0; i < 10 ; i++)
                {
                    res += num[i] + " ";
                }

                lblText .Text = res;

            }
            catch(Exception error)
            {
                lblText.Text = error.Message;
            }
            finally
            {
                MessageBox.Show("Operação finalizada !");
            }
        }
    }
}