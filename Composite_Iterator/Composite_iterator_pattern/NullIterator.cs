using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Iterator.Composite_iterator_pattern
{
    class NullIterator : IIterator
    {
        public bool hasNext()
        {
            return false;
        }

        public object next()
        {
            return null;
        }
    }
}
