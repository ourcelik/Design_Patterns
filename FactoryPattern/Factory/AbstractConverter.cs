using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FactoryPattern.Factory
{
    abstract class AbstractConverter
    {
       public TypeConverter GetInstance(string type)
        {
            TypeConverter converter;
            converter = CreateConverter(type);

            return converter;

        }
        protected abstract TypeConverter CreateConverter(string type);
    }
}
