﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
     public partial class Boleta
    {
        public int Numero { get; set; }
        public string? Cliente { get; set; }
        public string? Direccion { get; set; }
        public string? Cedula { get; set; }
        public DateTime Fecha { get; set; }
        public string? Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
