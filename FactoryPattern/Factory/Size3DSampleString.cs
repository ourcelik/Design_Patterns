using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factory
{
    class Size3DSampleString : ISampleString
    {
        private static Size3DSampleString Size3DSample; // volatile da eklenebilir
        //private static object CntrolObj = new object();
        private Size3DSampleString()
        {

        }
        public static ISampleString CreateInstance()
        {
            if (Size3DSample == null)
            {
                //lock (CntrolObj)
                //{
                    //if (Size3DSample == null)
                   // {
                        Size3DSample = new Size3DSampleString();
                   // }
                //}
            }
            return Size3DSample;
        }
        public string GetSampleString()
        {
            return "10,20,30";
        }
    }
}
