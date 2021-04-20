using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CommandPattern.Command
{
    class CEllipse : IThing
    {
        Ellipse ellipse; 
        public CEllipse(object obj)
        {
            ellipse = (Ellipse)obj;
        }
        public void BigWeight()
        {
            ellipse.Width = 300;
        }

        public void MakeBlue()
        {
            ellipse.Fill = new SolidColorBrush(Colors.Blue);
        }

        public void MakeRed()
        {
            ellipse.Fill = new SolidColorBrush(Colors.Red);
        }

        public void SmallWeight()
        {
            ellipse.Width = 150;
        }
    }
}
