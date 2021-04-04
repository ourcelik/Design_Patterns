using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.DecoratorClasses
{
    class RAM : Decorator
    {
        public RAM(IComputerFeatures features) : base(features)
        {
        }

        public override string ShowComputerFeatures()
        {
            return base.ShowComputerFeatures() + " 32GB RAM ADDED";
        }
        public override int ShowPrice()
        {
            return base.ShowPrice() + 500;
        }
    }
}
