using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command
{
    class MakeRedCommand : ICommand
    {
        IThing thing;
        public MakeRedCommand(IThing _thing)
        {
            thing = _thing;
        }
        public void Execute( )
        {
            thing.MakeRed();
        }

        public void Undo( )
        {
            thing.MakeBlue();
        }
    }
}
