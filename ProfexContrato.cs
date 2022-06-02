using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulacionExamen
{
    class ProfexContrato : Profesor
    {
        public ProfexContrato(string nombres, string apellidos, string direccion, string cedula) 
                    :base(nombres, apellidos, direccion, cedula)
        {

        }


    // Operaciones
        public override int CalcularSueldo(int sueldoBase, int precioxHora, int cantHorasTrabajadas)
        {
            return (precioxHora * cantHorasTrabajadas) + sueldoBase;
        }
    }
}
