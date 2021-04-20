using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command
{
    class BigWeightCommand : ICommand
    {
        IThing thing;
        public BigWeightCommand(IThing _thing)
        {
            thing = _thing;
        }
        public void Execute( )
        {
            thing.BigWeight();
        }

        public void Undo( )
        {
            thing.SmallWeight();
        }
    }
}
