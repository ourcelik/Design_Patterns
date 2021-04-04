using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.DecoratorClasses
{
    class SSD : Decorator
    {
        public SSD(IComputerFeatures features) : base(features)
        {
        }

        public override string ShowComputerFeatures()
        {
            return base.ShowComputerFeatures() + " 1TB SSD ADDED";
        }
        public override int ShowPrice()
        {
            return base.ShowPrice() + 2000;
        }
    }
}
