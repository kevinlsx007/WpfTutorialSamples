using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfTutorialSamples.Misc_controls
{
    /// <summary>
    /// Interaction logic for ProgressBarTaskOnUiThread.xaml
    /// </summary>
    public partial class ProgressBarTaskOnUiThread : Window
    {
        public ProgressBarTaskOnUiThread()
        {
            InitializeComponent();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                pbStatus.Value++;
                Thread.Sleep(100);
            }
        }
    }
}
