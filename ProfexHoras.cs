using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulacionExamen
{
    class ProfexHoras : Profesor
    {
        private int sueldo;
        public ProfexHoras(string nombres, string apellidos, string direccion, string cedula) 
                    : base(nombres, apellidos, direccion, cedula)
        {
        }


        public override int CalcularSueldo(int PrecioxH, int CantidadxH, int cero) 
        {
            return PrecioxH * CantidadxH;
        }

        public int Sueldo { get => sueldo; set => sueldo = value; }

    }
}
