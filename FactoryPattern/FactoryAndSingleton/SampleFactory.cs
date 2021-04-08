using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factory
{
    class SampleFactory : AbstractSample
    {
        #region ctor
        public SampleFactory()
        {

        }
        #endregion
        
        protected override ISampleString CreateInstance(string type)
        {
            if (type == "Point")
            {
                return PointSampleString.CreateInstance();
            }
            else if (type == "Matrix")
            {
                return MatrixSampleString.CreateInstance();
            }
            else if (type == "Vector")
            {
                return VectorSampleString.CreateInstance();
            }
            else if (type == "Point3D")
            {
                return Point3DSampleString.CreateInstance();
            }
            else if (type == "Vector3D")
            {
                return Vector3DSampleString.CreateInstance();
            }
            else if (type == "Size3D")
            {
                return Size3DSampleString.CreateInstance();
            }
            else if (type == "Point4D")
            {
                return Point4DSampleString.CreateInstance();
            }
            else
            {
                return null;
            }
        }
    }
}
