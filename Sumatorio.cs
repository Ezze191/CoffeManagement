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
        public string st_suma_cafe;

        
        

        public void sumar_uno_cafe()
        {
            int suma = suma_cafe + 1;

            suma_cafe = suma;

            st_suma_cafe = suma_cafe.ToString();  

        }

        public void restar_uno_cafe()
        {
            if(suma_cafe > 0) {
                int resta = suma_cafe - 1;

                suma_cafe = resta;

                st_suma_cafe = suma_cafe.ToString();
            }

        }
    }
}
