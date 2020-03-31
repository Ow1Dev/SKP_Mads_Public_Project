using Pizza.Mordel;
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

namespace Pizza.Windows
{
    /// <summary>
    /// Interaction logic for ShowProduct.xaml
    /// </summary>
    public partial class ShowProduct : Window
    {
        public PMenu item = null;

        public ShowProduct()
        {
            InitializeComponent();
        }
        
        public void Show(PMenu Menu)
        {
            this.Title = Menu.Name;
            item = Menu;

            this.Show();
        }
    }
}
