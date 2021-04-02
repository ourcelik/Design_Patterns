using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Iterator.Composite_iterator_pattern
{
    public class UnsupportedOperationException : Exception
    {
        private string message;


        public UnsupportedOperationException() : base()
        { }

        public UnsupportedOperationException(string message) : base(message)
        {
            this.message = message;
        }

        public override string Message
        {
            get
            {
                return this.message;
            }
        }
    }

}