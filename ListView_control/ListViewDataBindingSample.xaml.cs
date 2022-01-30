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

namespace WpfTutorialSamples.ListView_control
{
    /// <summary>
    /// Interaction logic for ListViewDataBindingSample.xaml
    /// </summary>
    public partial class ListViewDataBindingSample : Window
    {
        public ListViewDataBindingSample()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Name = "John Doe", Age = 42 });
            items.Add(new User() { Name = "Jane Doe", Age = 39 });
            items.Add(new User() { Name = "Sammy Doe", Age = 13 });
            lvDataBinding.ItemsSource = items;
        }
    }

    //public class User
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public string Mail { get; set; }
    //    Override ToString() method
    //    public override string ToString()
    //    {
    //        return this.Name + ", " + this.Age + " years old";
    //    }
    //}
}
