using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factory
{
    class MatrixSampleString : ISampleString
    {
        private  static MatrixSampleString matrixSample; // multi-thread durumlarda volatile da eklenebilir
        //private static object CntrolObj = new object();
        private MatrixSampleString()
        {

        }
        public static ISampleString CreateInstance()
        {
            if (matrixSample == null)
            {
               // lock(CntrolObj)
                //{
                   // if (matrixSample == null)
                    //{
                        matrixSample = new MatrixSampleString();
                    //}
                //}
            }
            return matrixSample;
        }
        public string GetSampleString()
        {
            return "10,20,30,40,50,60";
        }
    }
}
