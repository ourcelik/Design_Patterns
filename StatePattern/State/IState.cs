using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace CommandSourceControlWithDispatcherTimer.State_Pattern
{
    public interface IState
    {
        bool DisableButton(Slider slider);
        bool EnableButton(Slider slider);
        void WriteScreen(TextBlock txtResults, ExecutedRoutedEventArgs e);
    }
}
