using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulacionExamen
{
     class Program
    {
        static void Main(string[] args)
        {
            Profesor Profesor1 = new Profesor("Juan", "Flores", "Manta", "1221434");
            Profesor1.Imprimir();
            Profesor1.CalcularSueldo();
            Console.WriteLine("Su sueldo es de: "+PxHora.CalcularSueldo(2, 4));
            Console.ReadKey();
        }
 

    }
}
