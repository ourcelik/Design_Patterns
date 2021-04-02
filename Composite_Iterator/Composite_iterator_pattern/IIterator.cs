using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Iterator.Composite_iterator_pattern
{
    public interface IIterator
    {
        public Object next();
        public Boolean hasNext();

    }
}
