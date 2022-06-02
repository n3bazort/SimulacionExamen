using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulacionExamen
{
    class ProfexNombra : Profesor
    {
        
        public ProfexNombra(string nombres, string apellidos, string direccion, string cedula) 
                        : base(nombres, apellidos, direccion, cedula)
        {

        }        
        // Operaciones

        public override int CalcularSueldo(int sueldoBase, int precioxHora, int cantHorasTrabajadas)
        {
            int sueldo = (precioxHora * cantHorasTrabajadas) + sueldoBase;
            int aux = 0; 
            if (sueldo > 1000)
            { Console.WriteLine("El sueldo supera los $1000 USD: " );
                 aux=sueldo; }
            else if (sueldo < 1000)
            { Console.WriteLine("El sueldo NO supera los $1000 USD: " );
                 aux=sueldo;
            }
            return aux;
        }
    }
}
