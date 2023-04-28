namespace parte015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region Parte 01
            //Task parte1 = Task.Factory.StartNew(new Action(() =>
            //{
            //    Thread.Sleep(2000);
            //    progressBar.Invoke(new Action(() =>
            //    {
            //        progressBar.Value = 25;
            //    }));
            //}));

            //Task parte2 = parte1.ContinueWith((x) => 
            //{
            //    Thread.Sleep(2000);
            //    progressBar.Invoke(new Action(() =>
            //    {
            //        progressBar.Value = 50;
            //    }));
            //});

            //Task parte3 = parte2.ContinueWith((x) =>
            //{
            //    Thread.Sleep(2000);
            //    progressBar.Invoke(new Action(() =>
            //    {
            //        progressBar.Value = 75;
            //    }));
            //});

            //Task parte4 = parte3.ContinueWith((x) =>
            //{
            //    Thread.Sleep(2000);
            //    progressBar.Invoke(new Action(() =>
            //    {
            //        progressBar.Value = 100;
            //    }));
            //});

            #endregion

            List<Task> tasks = new List<Task>();
            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(1000);
                progressBar.Invoke(new Action(() => 
                {
                    progressBar.PerformStep();
                }));
            })));

            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(4236);
                progressBar.Invoke(new Action(() =>
                {
                    progressBar.PerformStep();
                }));
            })));

            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(456);
                progressBar.Invoke(new Action(() =>
                {
                    progressBar.PerformStep();
                }));
            })));
            progressBar.Maximum = tasks.Count();
            progressBar.Step = 1;

            for (int i = 0 ; i < tasks.Count; i++)
            {
                tasks[i].Start();
            }
        }
    }
}