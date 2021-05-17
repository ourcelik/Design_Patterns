﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ImageView
{
    public class LightSkyBlueType : ITextBlockColor
    {
        public void changeFont(TextBlock textBlock1, TextBlock textBlock2, TextBlock textBlock3)
        {
            textBlock1.Background = new SolidColorBrush(Colors.LightSkyBlue);
            textBlock2.Background = new SolidColorBrush(Colors.LightSkyBlue);
            textBlock3.Background = new SolidColorBrush(Colors.LightSkyBlue);
        }
    }
}
