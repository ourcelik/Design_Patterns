using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factory
{
    class Vector3DSampleString : ISampleString
    {
        private static Vector3DSampleString Vector3DSample; // volatile da eklenebilir
        //private static object CntrolObj = new object();
        private Vector3DSampleString()
        {

        }
        public static ISampleString CreateInstance()
        {
            //if (Vector3DSample == null)
            {
                //lock (CntrolObj)
                //{
                   // if (Vector3DSample == null)
                    //{
                        Vector3DSample = new Vector3DSampleString();
                    //}
                //}
            }
            return Vector3DSample;
        }
        public string GetSampleString()
        {
            return "10,20,30";
        }
    }
}
