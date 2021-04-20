using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command
{
    class NoneCommand : ICommand
    {
        public void Execute()
        {

        }

        public void Undo()
        {

        }
    }
}
