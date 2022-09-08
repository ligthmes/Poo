﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Boleta
    {
        public double DeterminaPrecio()
        {
            switch (Producto)
            {
                case "PS5 + 1 MANDO DS5": return 500;
                case "PS4(1TB) + 1 MANDO DS4": return 619;
                case "MANDO PS5/DS5": return 69;
                case "MANDO PS4/DS4": return 60;
            }
            return 0;
        }
    }
}
