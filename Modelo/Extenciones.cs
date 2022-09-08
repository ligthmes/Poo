using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public static class Extenciones
    {
        //EL metodo que existe debe ser esta´tico
        //El primer parámetro lleva this y representa el tipo que estamos 
        //extendido

        public static bool EsPar(this int i)
        {
            if (i % 2 == 0)
                return true;
            else
                return false;
        }
        public static double Duple(this double d)
        {
            return d * 2;
        }
    }
}
