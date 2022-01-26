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

namespace WpfTutorialSamples.Rich_text_controls
{
    /// <summary>
    /// Interaction logic for FlowDocumentSearchSample.xaml
    /// </summary>
    public partial class FlowDocumentSearchSample : Window
    {
        public FlowDocumentSearchSample()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            fdViewer.Find();
        }
    }
}
