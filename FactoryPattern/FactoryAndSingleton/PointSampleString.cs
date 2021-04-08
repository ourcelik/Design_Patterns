using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factory
{
    class PointSampleString : ISampleString
    {
        private static PointSampleString PointSample; // multi-thread durumlarda volatile da eklenebilir
       // private static object CntrolObj = new object();
        private PointSampleString()
        {

        }
        public static ISampleString CreateInstance()
        {
            if (PointSample == null)
            {
                //lock (CntrolObj) // multi-thread durumlarda eklenir
                //{
                    //if (PointSample == null)
                    //{
                        PointSample = new PointSampleString();
                    //}
                //}
            }
            return PointSample;
        }
        public string GetSampleString()
        {
            return "10,20";
        }
    }
}
