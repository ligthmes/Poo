using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contenedora
    {
        class Anidada
        {
            public void EscribirMensaje()
            {
                Console.WriteLine("Anidada.EscribirMensaje");

            }
        }
        public void Metodo()
        {
            Anidada aniadada = new Anidada();
            aniadada.EscribirMensaje();
        }
    }
}
