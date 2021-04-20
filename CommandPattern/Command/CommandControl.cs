using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command
{
    class CommandControl : ICommandControl
    {
        ICommand[] commands;
        ICommand Undocommand;
        public CommandControl()
        {
            commands = new ICommand[4];
            ICommand Nonecommand = new NoneCommand();
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i] = Nonecommand;
            }
            Undocommand = Nonecommand;
        }
        public void SetCommand(int slot, ICommand command)
        {
            commands[slot] = command;
        }
        public void ExecuteCommand(int slot)
        {
            commands[slot].Execute();
            Undocommand = commands[slot];
        }
        public void UndoCommand()
        {
            Undocommand.Undo();
        }
    }
}
