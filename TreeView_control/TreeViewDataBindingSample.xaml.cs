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
using System.IO;
using System.Collections.ObjectModel;

namespace WpfTutorialSamples.TreeView_control
{
    /// <summary>
    /// Interaction logic for TreeViewDataBindingSample.xaml
    /// </summary>
    public partial class TreeViewDataBindingSample : Window
    {
        public TreeViewDataBindingSample()
        {
            InitializeComponent();
            MenuItem root = new MenuItem() { Title = "Menu" };
            MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
            childItem1.Items.Add(new MenuItem() { Title = "Child item #1.1" });
            childItem1.Items.Add(new MenuItem() { Title = "Child item #1.2" });
            root.Items.Add(childItem1);
            root.Items.Add(new MenuItem() { Title = "Child item #2" });
            trvMenu.Items.Add(root);
        }
    }
    public class MenuItem
    {
        public MenuItem()
        {
            this.Items = new ObservableCollection<MenuItem>();
        }

        public string Title { get; set; }

        public ObservableCollection<MenuItem> Items { get; set; }
    }
}
