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
            ProfexHoras Profesor1 = new ProfexHoras("Juan", "Flores", "Manta", "131551434");
            Profesor1.Imprimir();
            int H = Profesor1.CalcularSueldo(2, 40, 0);
            Console.WriteLine("Su sueldo es de: $" + H);
            Console.ReadKey();

            ProfexContrato ProfeContrato1 = new ProfexContrato("Elías", "Cantos", "Montecirti", "131465431");
            ProfeContrato1.Imprimir();
            int C = ProfeContrato1.CalcularSueldo(400,2,40);
            Console.WriteLine("Su sueldo es de: $" + C);
            Console.ReadKey();

            ProfexNombra ProfeNombra1 = new ProfexNombra("Ulices", "Rivadeneira", "Guayaquil", "13158901941");
            ProfeNombra1.Imprimir();
            int N= ProfeNombra1.CalcularSueldo(400, 2, 160);
            Console.WriteLine("Su sueldo es de: $" + N);
            Console.Clear();
            Console.ReadKey();
        }
 

    }
}
