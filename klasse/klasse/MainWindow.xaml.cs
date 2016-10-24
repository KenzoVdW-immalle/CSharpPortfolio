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

namespace klasse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Balloon balloon;

        public MainWindow()
        {
            
            InitializeComponent();

            balloon = new Balloon();
            balloon.DisplayOn(drawingCanvas);
           
        }

        private void growButton_Click(object sender, RoutedEventArgs e)
        {
            balloon.ChangeSize(50);
        }

        private void moveButton_Click(object sender, RoutedEventArgs e)
        {
            balloon.moveright(20);
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            balloon.DownSize(50);
        }

        private void MoveleftButton_Click(object sender, RoutedEventArgs e)
        {
            balloon.moveLeft(20);
        }
    }
}
