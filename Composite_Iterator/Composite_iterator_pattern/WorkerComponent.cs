using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite_Iterator.Composite_iterator_pattern
{
    public abstract class WorkerComponent : IteratorAggregate
    {
        string name;
        string description;
        double salary;
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual string Description
        {
            get { return description; }
            set { description = value; }
        }
        public virtual double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public virtual void Add(WorkerComponent component)
        {
            throw new UnsupportedOperationException();
        }

        public virtual void Remove(WorkerComponent component)
        {
            throw new UnsupportedOperationException();
        }

        public virtual WorkerComponent GetChild(int i)
        {
            throw new UnsupportedOperationException();
        }

        public virtual string Print()
        {
            throw new UnsupportedOperationException();
        }

        public virtual ArrayList GetWorker()
        {
            throw new UnsupportedOperationException();
        }

        public virtual int Count()
        {
            throw new UnsupportedOperationException();
        }

        public virtual IIterator CreateIterator()
        {
            throw new UnsupportedOperationException();
        }
    }
}
