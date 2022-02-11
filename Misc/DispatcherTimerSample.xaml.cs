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
using System.Windows.Threading;

namespace WpfTutorialSamples.Misc
{
    /// <summary>
    /// Interaction logic for DispatcherTimerSample.xaml
    /// </summary>
    public partial class DispatcherTimerSample : Window
    {
        public DispatcherTimerSample()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Content = DateTime.Now.ToString("HH:mm:ss.fff");
        }
    }
}
