using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using factoryMethod.Properties;


namespace factoryMethod
{
   public abstract class AbstractFactory
    {
        public static int audio = 1;
        public static int video = 2;

        public abstract IArchivo crear(int tipo);
        

    }
}
