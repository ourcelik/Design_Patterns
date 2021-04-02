using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite_Iterator.Composite_iterator_pattern
{
    class Composite : WorkerComponent
    {
        IIterator Iterator = null;
        ArrayList WorkerComponents = new ArrayList();
        #region Items
        string name;
        string description;
        #endregion

        #region Ctor

        public Composite(string name, string description)
        {
            this.name = name;
            this.description = description;
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

        #endregion
        public override void Add(WorkerComponent component)
        {
            WorkerComponents.Add(component);
        }

        public override void Remove(WorkerComponent component)
        {
            WorkerComponents.Remove(component);

        }

        public override WorkerComponent GetChild(int i)
        {
            return (WorkerComponent)WorkerComponents[i];
        }

        public override string Print()
        {
            StringBuilder printOutput = new StringBuilder();
            printOutput.Append("\n" + Name);
            printOutput.Append(", " + description + "\n");
            printOutput.Append("--------------------------\n");
            foreach(WorkerComponent worker in WorkerComponents)
            {
                printOutput.Append(worker.Print());
            }
            return printOutput.ToString();

            
        }

        public override ArrayList GetWorker()
        {
            return WorkerComponents;
        }

        public override int Count()
        {
            return WorkerComponents.Count;
        }
        public override IIterator CreateIterator()
        {
            if (Iterator == null)
            {
                Iterator = new CompositeIterator(WorkerComponents);
            }
            return Iterator;
        }
    }
}
