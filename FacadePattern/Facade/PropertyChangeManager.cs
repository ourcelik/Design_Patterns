using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace ImageView
{
    class PropertyChangeManager
    {
        private Facade _facade;
        public PropertyChangeManager()
        {
            _facade = new Facade();
        }

        public void changePropertyGreenYellow(TextBlock textBlock1, TextBlock textBlock2, TextBlock textBlock3)
        {
            _facade.greenYellow.changeFont(textBlock1, textBlock2, textBlock3);
        }

        public void changePropertyGray(TextBlock textBlock1, TextBlock textBlock2, TextBlock textBlock3)
        {
            _facade.gray.changeFont(textBlock1, textBlock2, textBlock3);
        }
        public void changePropertyLightPink(TextBlock textBlock1, TextBlock textBlock2, TextBlock textBlock3)
        {
            _facade.lightPink.changeFont(textBlock1, textBlock2, textBlock3);
        }
        public void changePropertyLightSkyBlue(TextBlock textBlock1, TextBlock textBlock2, TextBlock textBlock3)
        {
            _facade.lightSkyBlue.changeFont(textBlock1, textBlock2, textBlock3);
        }

    }
}
