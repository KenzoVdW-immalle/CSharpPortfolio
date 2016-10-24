using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace klasse
{
    public class Balloon
    {
        private int x = 50;
        private int y = 50;
        private int diameter = 20;
        private Ellipse ellipse;

        public Balloon()
        {
            createEllipse();
            updateEllipse();
        }
        public void moveright(int xstep)
        {
            x = x + xstep;
            updateEllipse();
        }
        public void moveLeft(int xstep)
        {
            x = x - xstep;
            updateEllipse();
        }
        public void ChangeSize(int chance)
        {
            diameter = diameter + chance;
            updateEllipse();
        }
        public void DownSize(int change)
        {
            if (diameter > 20)
            {
               diameter = diameter - change;
            }
            else
            {
                MessageBox.Show("de ballon is te klein om nog kleiner te worden");
            }
            
            updateEllipse();

        }
        public void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(ellipse);
        }
        private void createEllipse()
        {
            ellipse = new Ellipse();
            ellipse.Stroke = new SolidColorBrush(Colors.Blue);
            ellipse.StrokeThickness = 5;
        }
        private void updateEllipse()
        {
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Width = diameter;
            ellipse.Height = diameter * 2;
        }
    }
}
