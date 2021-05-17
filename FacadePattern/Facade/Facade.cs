using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace ImageView
{
    public class Facade
    {
        public ITextBlockColor greenYellow;
        public ITextBlockColor lightSkyBlue;
        public ITextBlockColor gray;
        public ITextBlockColor lightPink;


        public Facade()
        {
            lightSkyBlue = new LightSkyBlueType();
            gray = new GrayType();
            lightPink = new LightPinkType();
            greenYellow = new GreenYellowType();
        }

    }
}
