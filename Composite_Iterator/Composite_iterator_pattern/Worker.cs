using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Iterator.Composite_iterator_pattern
{    class worker : WorkerComponent
    {

        #region Items
        string name;
        string description;
        double salary;
        #endregion

        #region Ctor

        public worker(string name,string description,double salary)
        {
            this.name = name;
            this.description = description;
            this.salary = salary;
        }
        #endregion

        #region Properties
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string Description
        {
            get { return description; }
            set { description = value; }
        }
        public override double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        #endregion
        public override string Print()
        {
            StringBuilder printOutput = new StringBuilder();
            printOutput.Append("\t" + Name);
            printOutput.Append(", $" + Salary);
            printOutput.Append("About : " + Description + "\n");

            return printOutput.ToString();
        }
        public override IIterator CreateIterator()
        {
            return new NullIterator();
        }

    }
}
