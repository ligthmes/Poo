using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
     public class Estaciones
    {

        public Estacion _verano;

        public Estacion verano
        {
            get
            {
                if (this.verano == null)
                {
                    _verano = new Estacion(6, 21, 9, 20);
                }
                return _verano;

            }
        }

        public Estacion _otoño;

        public Estacion otoño
        {
            get
            {
                if (this.otoño == null)
                {
                    _otoño = new Estacion(7, 23, 8, 30);
                }
                return _otoño;
            }

        }

        public Estacion _Invierno;

        public Estacion Invierno
        {
            get
            {
                if (this.Invierno == null)
                {
                    _Invierno = new Estacion(7, 23, 8, 30);
                }
                return _Invierno;
            }
        }

        public class Estacion
        {
            public Estacion(byte mesInicio, byte diaInicio, byte mesFin, byte diaFin)
            {
                this.MesInicio = mesInicio;
                this.DiaInicio = diaInicio;
                this.MesFin = mesFin;
                this.DiaFin = diaFin;
            }
            public byte MesInicio { get; set; }

            public byte DiaInicio { get; set; }
            public byte MesFin { get; set; }

            public byte DiaFin { get; set; }

        }

    }
}
