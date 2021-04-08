using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace FactoryPattern.Factory

{
    class   ConverterFactory : AbstractConverter
    {
        #region ctor
        public ConverterFactory()
        {

        }
        #endregion
        protected override TypeConverter CreateConverter(string type)
        {
            if (type.Equals("Point"))
            {
                return new PointConverter();
            }
            else if (type.Equals("Matrix"))
            {
                return new MatrixConverter();
            }
            else if (type.Equals("Vector"))
            {
                return new VectorConverter();
            }
            else if (type.Equals("Point3D"))
            {
                return new Point3DConverter();
            }
            else if (type.Equals("Vector3D"))
            {
                return new Vector3DConverter();
            }
            else if (type.Equals("Size3D"))
            {
                return new Size3DConverter();
            }
            else if (type.Equals("Point4D"))
            {
                return new Point4DConverter();
            }
            else
            {
                return null; 
            }
        }

    }
}
