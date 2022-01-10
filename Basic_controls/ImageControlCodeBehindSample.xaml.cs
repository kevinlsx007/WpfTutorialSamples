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
using Microsoft.Win32; // OpenFileDialog

namespace WpfTutorialSamples.Basic_controls
{
    /// <summary>
    /// Interaction logic for ImageControlCodeBehindSample.xaml
    /// </summary>
    public partial class ImageControlCodeBehindSample : Window
    {
        public ImageControlCodeBehindSample()
        {
            InitializeComponent();
        }

        private void BtnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                imgDynamic.Source = new BitmapImage(fileUri);
            }
        }

        private void BtnLoadFromResource_Click(object sender, RoutedEventArgs e)
        {
            // Relative to root of the application
            Uri resourceUri = new Uri("/Images/white_bengal_tiger.jpg", UriKind.Relative);
            imgDynamic.Source = new BitmapImage(resourceUri);
        }
    }
}
