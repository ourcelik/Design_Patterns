using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
