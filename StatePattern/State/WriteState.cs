using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace StatePattern.State
{
    class WriteState : IState
    {
        ContextTime Context;
        public WriteState(ContextTime context)
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
            return true;
            
        }

        public void WriteScreen(TextBlock txtResults, ExecutedRoutedEventArgs e)
        {
            txtResults.Text = "Command Executed at " +
                              DateTime.Now.Second + " seconds after the minute \n\n" +
                              "The target second is set to " +
                              e.Parameter;
        }
    }
}
