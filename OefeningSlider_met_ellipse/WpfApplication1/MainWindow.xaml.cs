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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ellipse ellipse1;
       
        public MainWindow()
        {
            InitializeComponent();
            ValueSlider.Minimum = 0;
            ValueSlider.Maximum = 100;

            DrawEllipse();
            
            
        }

        private void ValueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = Convert.ToInt32(ValueSlider.Value);
            ValueLabel.Content = Convert.ToString(value);
            updateEllipse();

        }
        private void DrawEllipse()
        {
            ellipse1 = new Ellipse();
            ellipse1.Width = ValueSlider.Value;
            ellipse1.Height = ValueSlider.Value;
            ellipse1.Stroke = new SolidColorBrush(Colors.Blue);
            ellipse1.Margin = new Thickness(10, 0, 0, 0);
            drawingcanvas.Children.Add(ellipse1);

            
        }
        private void updateEllipse()
        {
            ellipse1.Width = ValueSlider.Value;
            ellipse1.Height = ValueSlider.Value;
            
        }
    }
}
