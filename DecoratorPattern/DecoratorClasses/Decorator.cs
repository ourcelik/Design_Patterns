using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.DecoratorClasses
{
    public abstract class Decorator: IComputerFeatures
    {
        private IComputerFeatures features;

        public Decorator(IComputerFeatures features)
        {
            this.features = features;
        }

        public virtual string ShowComputerFeatures()
        {
            return features.ShowComputerFeatures();
        }

        public virtual int ShowPrice()
        {
            return features.ShowPrice();
        }
    }
}
