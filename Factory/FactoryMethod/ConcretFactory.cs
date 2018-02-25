using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using factoryMethod.Properties;



namespace factoryMethod
{
    public class ConcretFactory:AbstractFactory
    {       
        public override IArchivo crear(int tipo)
        {
            IArchivo objeto;
            switch (tipo)
            {
                
                case 1:
                   objeto = new ConcrectProductArchAudio();
                    return objeto;
                    break;
                case 2:
                    return new ConcrectProductArchVideo();                   
                default:
                    return null;
            }            
        }
    }
}
