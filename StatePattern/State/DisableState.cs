using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace CommandSourceControlWithDispatcherTimer.State_Pattern
{
    class DisableState : IState
    {
        ContextTime Context;
        public DisableState(ContextTime context)
        {
            this.Context = context;
        }

        public bool DisableButton( Slider slider)
        {
            
            if (DateTime.Now.Second > slider.Value)
            {
                Context.stateOfSystem = new EnableState(Context);
                return true;
            }
            return false;
           
        }

        public bool EnableButton(Slider slider)
        {
            return false;

        }

        public void WriteScreen(TextBlock txtResults, ExecutedRoutedEventArgs e)
        {
            
        }

    }
}
