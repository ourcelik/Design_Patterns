using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace DecoratorPattern.DecoratorClasses
{
    class GPU: Decorator
    {
        public GPU(IComputerFeatures features) : base(features)
        {
        }

        public override string ShowComputerFeatures()
        {
            return base.ShowComputerFeatures() + " 2080 GPU ADDED";
        }
        public override int ShowPrice()
        {
            return base.ShowPrice() + 4000;
        }
    }
}
