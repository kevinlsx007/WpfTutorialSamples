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
using System.Globalization;
using System.Threading;

namespace WpfTutorialSamples.WPF_Application
{
    /// <summary>
    /// Interaction logic for ApplicationCultureSwitchSample.xaml
    /// </summary>
    public partial class ApplicationCultureSwitchSample : Window
    {
        public ApplicationCultureSwitchSample()
        {
            InitializeComponent();
        }

        private void CultureInfoSwitchButton_Click(object sender, RoutedEventArgs e)
        {
            // Syntax option 1 for casting to Button
            //Thread.CurrentThread.CurrentCulture = new CultureInfo((sender as Button).Tag.ToString());
            // Syntax option 2 for casting to Button
            Button btn = (Button)sender;
            Thread.CurrentThread.CurrentCulture = new CultureInfo(btn.Tag.ToString());
            lblNumber.Content = (123456789.42d).ToString("N2");
            lblDate.Content = DateTime.Now.ToString();
        }
    }
}
