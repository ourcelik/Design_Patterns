using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factory
{
    abstract class AbstractSample
    {
        public string TakeSample(string type)
        {
            ISampleString sampleString;
            sampleString = CreateInstance(type);

            return sampleString.GetSampleString();
        }
        protected abstract ISampleString CreateInstance(string type);
    }
}
