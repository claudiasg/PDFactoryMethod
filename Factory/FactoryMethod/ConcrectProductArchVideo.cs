using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace factoryMethod
{
   public class ConcrectProductArchVideo: IArchivo
    {
        public void Reproducir() {
            MessageBox.Show("Reproduciendo un archivo de video......");
        } 
            
    }
}
