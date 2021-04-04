using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace DecoratorPattern.DecoratorClasses
{
    public class ComputerFeatures : IComputerFeatures
    {
        public string ShowComputerFeatures()
        {
            return "Clasic pc Created";
        }

        public int ShowPrice()
        {
            return 4000;
        }
    }
}
