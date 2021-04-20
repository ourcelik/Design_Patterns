using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace CommandPattern.Command
{
    class Text : IThing
    {
        TextBlock TextArea;
        public Text(object Texter)
        {
            TextArea = (TextBlock)Texter; 
        }

        public void BigWeight()
        {
            TextArea.Width = 300;
            TextArea.FontSize = 50;
        }

        public void MakeBlue()
        {
            TextArea.Foreground = new SolidColorBrush(Colors.Blue);
        }

        public void MakeRed()
        {
            TextArea.Foreground = new SolidColorBrush(Colors.Red);
        }

        public void SmallWeight()
        {
            TextArea.Width = 150;
            TextArea.FontSize = 20;
        }
    }
}
