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
using Pizza.Mordel;
using Pizza.Windows;

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
                    new PMenu("test 1"),
                    new PMenu("test 2"),
                    new PMenu("test 3"),
                    new PMenu("test 4"),
                    new PMenu("test 5"),
                    new PMenu("test 6"),
                    new PMenu("test 7"),
                    new PMenu("test 8"),
                    new PMenu("test 9"),
                    new PMenu("test 0")
                }

            },
            new PCatergory
            {
                Name = "Drinks",
                Items = new List<PMenu>
                {
                    new PMenu("test 2"),
                }

            }
        };

        public MainWindow()
        {
            InitializeComponent();

            //puts products in itemSource and set selected to the first one
            CatergoryList.ItemsSource = catergories;
            CatergoryList.SelectedValue = 0;

            ChangeGridView(catergories[0].Items);
        }

        private void ChangeGridView(List<PMenu> items)
        {
            //Clear Menubar
            MenuBar.Children.Clear();

            //Get every item and add a label
            foreach (var item in items)
            {
                //Crate a Label
                var label = new PLabel() { Margin = new Thickness(10), Width = 50, Height = 50, Background = Brushes.Yellow, Content = item.Name, Cursor = Cursors.Hand };

                //Puts the item in to label
                label.Menu = item;

                //Add event and show the label
                label.MouseLeftButtonDown += Label_MouseLeftButtonDown;
                MenuBar.Children.Add(label);
            }
        }

        private void CatergoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView s = sender as ListView;
            var items = ((PCatergory)s.SelectedItem).Items;
            ChangeGridView(items);
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            new ShowProduct().Show(((PLabel)sender).Menu);
        }
    }
    
    public class PLabel : Label
    {
        public PMenu Menu { get; set; }
    }
}
