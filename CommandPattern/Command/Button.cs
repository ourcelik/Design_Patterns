using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace CommandPattern.Command
{
    class CButton : IThing
    {
        Button Button;
        public CButton(object Btn)
        {
            Button = (Button)Btn;
        }
        public void BigWeight()
        {
            Button.Width = 300;
            Button.FontSize = 30;
        }

        public void MakeBlue()
        {
            Button.Foreground = new SolidColorBrush(Colors.Blue);
        }

        public void MakeRed()
        {
            Button.Foreground = new SolidColorBrush(Colors.Red);
        }

        public void SmallWeight()
        {
            Button.Width = 150;
            Button.FontSize = 20;
        }
    }
}
