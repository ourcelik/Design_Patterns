using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factory
{
    class VectorSampleString : ISampleString
    {
        private static VectorSampleString VectorSample; // volatile da eklenebilir
        //private static object CntrolObj = new object();
        private VectorSampleString()
        {

        }
        public static ISampleString CreateInstance()
        {
            if (VectorSample == null)
            {
                //lock (CntrolObj)
                //{
                    //if (VectorSample == null)
                    //{
                        VectorSample = new VectorSampleString();
                    //}
                //}
            }
            return VectorSample;
        }
        public string GetSampleString()
        {
            return "10,20";
        }
    }
}
