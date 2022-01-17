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
    /// Interaction logic for UpdateSourceTriggerSample.xaml
    /// </summary>
    public partial class UpdateSourceTriggerSample : Window
    {
        public UpdateSourceTriggerSample()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void btnUpdateSource_Click(object sender, RoutedEventArgs e)
        {
            // First get the binding from the destination control
            // GetBindingExpression returns the BindingExpression that represents the binding on the specified property
            BindingExpression binding = txtWindowTitle.GetBindingExpression(TextBox.TextProperty);
            // Update source of the binding
            binding.UpdateSource();
        }
    }
}
