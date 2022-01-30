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

namespace WpfTutorialSamples.ItemsControl
{
    /// <summary>
    /// Interaction logic for ComboBoxDataBindingSample.xaml
    /// </summary>
    public partial class ComboBoxDataBindingSample : Window
    {
        public ComboBoxDataBindingSample()
        {
            InitializeComponent();
            cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }
    }
}
