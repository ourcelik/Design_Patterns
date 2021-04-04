using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.DecoratorClasses
{
    class IPS : Decorator
    {
        public IPS(IComputerFeatures features) : base(features)
        {
        }

        public override string ShowComputerFeatures()
        {
            return base.ShowComputerFeatures() + " IPS Screen ADDED";
        }
        public override int ShowPrice()
        {
            return base.ShowPrice() + 2000;
        }
    }
}
