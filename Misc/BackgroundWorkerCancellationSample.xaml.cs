using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;

namespace WpfTutorialSamples.Misc
{
    /// <summary>
    /// Interaction logic for BackgroundWorkerCancellationSample.xaml
    /// </summary>
    public partial class BackgroundWorkerCancellationSample : Window
    {
        private BackgroundWorker worker = null;
        public BackgroundWorkerCancellationSample()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork; ;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                worker.ReportProgress(i);
                System.Threading.Thread.Sleep(250);
            }
            e.Result = 42;
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = "Working... (" + e.ProgressPercentage + "%)";
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblStatus.Foreground = Brushes.Red;
                lblStatus.Text = "Cancelled by user...";
            }
            else
            {
                lblStatus.Foreground = Brushes.Green;
                lblStatus.Text = "Done... Calc result: " + e.Result;
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            worker.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            worker.CancelAsync();
        }
    }
}
