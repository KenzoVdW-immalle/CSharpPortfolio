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
using System.Windows.Threading;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += timer_Tick;



            Console.WriteLine("/a");

           
        }
        public void timer_Tick(object sender, EventArgs args)
        {
            timer.Stop();
            string hi = "\n tick";
            ContentLabel.Content += (hi);
            timer.Start();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

    }
}
