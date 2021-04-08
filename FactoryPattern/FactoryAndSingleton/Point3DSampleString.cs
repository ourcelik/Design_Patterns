using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factory
{
    class Point3DSampleString : ISampleString
    {
        private volatile static Point3DSampleString Point3DSample; // volatile da eklenebilir
        //private static object CntrolObj = new object();
        private Point3DSampleString()
        {

        }
        public static ISampleString CreateInstance()
        {
            if (Point3DSample == null)
            {
                // lock(CntrolObj)
                //{
                // if (matrixSample == null)
                //{
                Point3DSample = new Point3DSampleString();
                //}
                //}
            }
            return Point3DSample;
        }
        public string GetSampleString()
        {
            return "10,20,30";
        }
    }
}
