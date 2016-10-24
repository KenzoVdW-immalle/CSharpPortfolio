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

namespace Oefening_met_listbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            listBox_1.Items.Add(textBoxText.Text);
        }
        
private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int remove = Convert.ToInt32(textBoxRemove.Text) - 1;
            listBox_1.Items.RemoveAt(remove);
        }
    }
}
