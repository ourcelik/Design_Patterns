using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command
{
    class MakeBlueCommand :ICommand
    {
        IThing thing;
        public MakeBlueCommand(IThing _thing)
        {
            thing = _thing;
        }
        public void Execute( )
        {
            thing.MakeBlue();
        }

        public void Undo( )
        {
            thing.MakeRed();
        }
    }
}
