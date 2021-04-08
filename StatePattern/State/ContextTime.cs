using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace StatePattern.State
{
    public class ContextTime
    {
        IState DisableButtonState;
        IState EnableButtonState;
        IState WriteState;
        IState CurrentState;

        #region Properties


        public IState stateOfSystem
        {
            get { return CurrentState; }
            set { CurrentState = value; }
        }

        #endregion
        #region Constructor

        public ContextTime()
        {
            DisableButtonState = new DisableState(this);
            EnableButtonState = new EnableState(this);
            WriteState = new WriteState(this);
            CurrentState = DisableButtonState;

        }
        #endregion

        #region Work_State_Area
        public bool DisableButton( Slider slider)
        {
            return CurrentState.DisableButton(slider);
        }
        public bool EnableButton(Slider slider)
        {
           return  CurrentState.EnableButton(slider);
        }
        public void WriteScreen(TextBlock txtResults, ExecutedRoutedEventArgs e)
        {
            CurrentState.WriteScreen(txtResults,e);
        }

        #endregion

    }
}
