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

namespace WpfTutorialSamples.Misc_controls
{
    /// <summary>
    /// Interaction logic for CalendarBlockedoutDatesSample.xaml
    /// </summary>
    public partial class CalendarBlockedoutDatesSample : Window
    {
        public CalendarBlockedoutDatesSample()
        {
            InitializeComponent();
            cldSample.BlackoutDates.AddDatesInPast();
            cldSample.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
        }
    }
}
