using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factory
{
    class Point4DSampleString : ISampleString
    {
        private static Point4DSampleString Point4DSample; // volatile da eklenebilir
        //private static object CntrolObj = new object();
        private Point4DSampleString()
        {

        }
        public static ISampleString CreateInstance()
        {
            if (Point4DSample == null)
            {
                //lock (CntrolObj)
                //{
                    //if (Point4DSample == null)
                    //{
                        Point4DSample = new Point4DSampleString();
                    //}
                //}
            }
            return Point4DSample;
        }
        public string GetSampleString()
        {
            return "10,20,30,40";
        }
    }
}
