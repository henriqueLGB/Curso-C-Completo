namespace parte032
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!bgWorker.IsBusy)
            {
                bgWorker.RunWorkerAsync();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (bgWorker.WorkerSupportsCancellation)
            {
                bgWorker.CancelAsync();
            }
        }

        private void bgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (bgWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Thread.Sleep(500);
                    bgWorker.ReportProgress(i * 10);
                }
            }
        }

        private void bgWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            lblProgresso.Text = e.ProgressPercentage.ToString() + " % ";
            progressBar.Value = e.ProgressPercentage;
        }

        private void bgWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblProgresso.Text = "Cancelado !";
            }
            else if (e.Error != null)
            {
                lblProgresso.Text = e.Error.Message;
            }
            else
            {
                lblProgresso.Text = "100 % Concluído !";
                progressBar.Value = 100;
            }
        }
    }
}