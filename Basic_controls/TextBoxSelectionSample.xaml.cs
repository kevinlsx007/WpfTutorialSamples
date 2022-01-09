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

namespace WpfTutorialSamples.Basic_controls
{
    /// <summary>
    /// Interaction logic for TextBoxSelectionSample.xaml
    /// </summary>
    public partial class TextBoxSelectionSample : Window
    {
        public TextBoxSelectionSample()
        {
            InitializeComponent();
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            // Cast the sender to TextBox object
            TextBox textBox = sender as TextBox;
            // Show detailed selection changing info in txtStatus
            txtStatus.Text = "Selection starts at character #" + textBox.SelectionStart + Environment.NewLine;
            txtStatus.Text += "Selection is " + textBox.SelectionLength + " character(s) long" + Environment.NewLine;
            txtStatus.Text += "Selected text: '" + textBox.SelectedText + "'";
        }
    }
}
