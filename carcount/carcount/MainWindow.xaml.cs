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

namespace carcount
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int carcount = 0;
        public MainWindow()
        {
            
            InitializeComponent();
            
        }

        private void enterCar_Click(object sender, RoutedEventArgs e)

        {
            carcount = carcount + 1;
            CarCountLabel.Content = Convert.ToString(carcount);
            int a, b;
            b = 1;
            a = b;
            
            
        }

        private void LeaveCar_Click(object sender, RoutedEventArgs e)
        {
            if(carcount > 0)
            {
            carcount = carcount - 1;
            CarCountLabel.Content = Convert.ToString(carcount);
            }
            else
            {
                MessageBox.Show("er kunnen geen auto's meer weggaan! er zijn 0 auto's in de garage!");
            }
            

        }
    }
}
