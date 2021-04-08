using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace StatePattern.State
{
    class EnableState : IState
    {
        ContextTime Context;
        public EnableState(ContextTime context)
        {
            this.Context = context;
        }
        public bool DisableButton(Slider slider)
        {
            return false;
        }

        public bool EnableButton(Slider slider)
        {
            if (DateTime.Now.Second < slider.Value)
            {
                Context.stateOfSystem = new DisableState(Context);
                return false;
            }
            Context.stateOfSystem = new WriteState(Context);
            return true;
        }


        public void WriteScreen(TextBlock txtResults, ExecutedRoutedEventArgs e)
        {
            
        }

      
    }
}
