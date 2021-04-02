using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite_Iterator.Composite_iterator_pattern
{
    class CompositeIterator : IIterator
    {
        Stack<IIterator> stack = new Stack<IIterator>();
        ArrayList array = new ArrayList();
        int position = 0;
        public CompositeIterator(ArrayList list)
        {
            array = list;
        }

        public bool hasNext()
        {
            if (position >= array.Count || array[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object next()
        {
            WorkerComponent menuItem = (WorkerComponent)array[position];
            position += 1;
            return menuItem;
        }

    }
}
