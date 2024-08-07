using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    public class Sumatorio
    {
        public int suma_cafe = 0;
       

        
        

        public void sumar_uno_cafe()
        {
            int suma = suma_cafe + 1;

            suma_cafe = suma;

            

        }

        public void restar_uno_cafe()
        {
            if(suma_cafe > 0) {
                int resta = suma_cafe - 1;

                suma_cafe = resta;

               
            }

        }
    }
}
