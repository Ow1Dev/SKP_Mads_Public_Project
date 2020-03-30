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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pizza
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<PCatergory> catergories = new List<PCatergory>
        {
            new PCatergory
            {
                Name = "Pizza",
                Items = new List<PMenu>
                {
                    new PMenu("test 1")
                }

            },
            new PCatergory
            {
                Name = "Drinks",
                Items = new List<PMenu>
                {
                    new PMenu("test 2")
                }

            }
        };

        public MainWindow()
        {
            InitializeComponent();

            CatergoryList.ItemsSource = catergories;
            CatergoryList.SelectedValue = 0;

            ChangeGridView(catergories[0].Items);
        }

        private void CatergoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView s = sender as ListView;
            var items = ((PCatergory)s.SelectedItem).Items;
            ChangeGridView(items);
        }

        private void ChangeGridView(List<PMenu> items)
        {
            MenuBar.Children.Clear();

            foreach (var item in items)
            {
                MenuBar.Children.Add(new Label() { Margin = new Thickness(10), Width = 50, Height = 50, Background = Brushes.Yellow, Content = item.Name });
            }
        }
    }

    public class PCatergory
    {
        public string Name { get; set; }
        public List<PMenu> Items { get; set; } = new List<PMenu>();

        public override string ToString()
        {
            return Name;
        }
    }

    public class PMenu
    {
        public string Name { get; set; }
        public PMenu(string name)
        {
            Name = name;
        }
    }
}
