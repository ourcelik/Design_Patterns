using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace DecoratorPattern.DecoratorClasses
{
    public class CPU: Decorator
    {
        private int generation;
        /*private int thirdgen = 3;
        private int fifthgen = 5;
        private int seventhgen = 7;*/
        public CPU(IComputerFeatures features) : base(features)
        {
        }
        public override string ShowComputerFeatures()
        {
            return base.ShowComputerFeatures() + " Added 7th Generation CPU";
        }
        public override int ShowPrice()
        {
            return base.ShowPrice()+1500;
        }

    }
}
