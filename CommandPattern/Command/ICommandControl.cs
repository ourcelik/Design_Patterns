using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command
{
    interface ICommandControl
    {
        void SetCommand(int slot, ICommand command);
        void ExecuteCommand(int slot);
        void UndoCommand();

    }
}
