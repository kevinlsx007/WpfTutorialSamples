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

namespace WpfTutorialSamples.DataBinding
{
    /// <summary>
    /// Interaction logic for CodeBehindBindingsSample.xaml
    /// </summary>
    public partial class CodeBehindBindingsSample : Window
    {
        public CodeBehindBindingsSample()
        {
            InitializeComponent();

            Binding binding = new Binding("Text"); // initiate a Binding object, passing "Text" path to constructor
            binding.Source = txtValue; // set the source of the Binding object
            // set the destination of the Binding object, passing dependency property and Binding object as args
            lblValue.SetBinding(TextBlock.TextProperty, binding);
        }
    }
}
