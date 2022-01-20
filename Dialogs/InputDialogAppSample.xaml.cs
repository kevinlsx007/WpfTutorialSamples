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

namespace WpfTutorialSamples.Dialogs
{
    /// <summary>
    /// Interaction logic for InputDialogAppSample.xaml
    /// </summary>
    public partial class InputDialogAppSample : Window
    {
        public InputDialogAppSample()
        {
            InitializeComponent();
        }

        private void btnEnterName_Click(object sender, RoutedEventArgs e)
        {
            InputDialogSample inputDialog = new InputDialogSample("Please enter your name:", "John Doe");
            if (inputDialog.ShowDialog() == true)
                lblName.Text = inputDialog.Answer;
        }
    }
}
