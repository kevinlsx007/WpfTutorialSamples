﻿using System;
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
    /// Interaction logic for BlockUIContainerSample.xaml
    /// </summary>
    public partial class BlockUIContainerSample : Window
    {
        public BlockUIContainerSample()
        {
            InitializeComponent();
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
