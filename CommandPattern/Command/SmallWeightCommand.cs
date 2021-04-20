using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command
{
    class SmallWeightCommand : ICommand
    {
        IThing thing;
        public SmallWeightCommand(IThing _thing)
        {
            thing = _thing;
        }
        public void Execute()
        {
            thing.SmallWeight();
        }

        public void Undo()
        {
            thing.BigWeight();
        }
    }
}
