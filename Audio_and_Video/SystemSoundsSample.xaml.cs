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
using System.Media;

namespace WpfTutorialSamples.Audio_and_Video
{
    /// <summary>
    /// Interaction logic for SystemSoundsSample.xaml
    /// </summary>
    public partial class SystemSoundsSample : Window
    {
        public SystemSoundsSample()
        {
            InitializeComponent();
        }

        private void btnAsterisk_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Asterisk.Play();
        }

        private void btnBeep_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void btnExclamation_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void btnHand_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Hand.Play();
        }

        private void btnQuestion_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Question.Play();
        }
    }
}
