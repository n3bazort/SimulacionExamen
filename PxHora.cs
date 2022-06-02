using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulacionExamen
{
    class PxHora : Profesor
    {

        public PxHora(string nombres, string apellidos, string direccion, string cedula)
            : base(nombres, apellidos, direccion, cedula)
        {
        }

         public PxHora()
        { }

        public override int CalcularSueldo(int PrecioxH, int CantidadxH) 
        {
            return PrecioxH * CantidadxH;
        }
      
    }
}
