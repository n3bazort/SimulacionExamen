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
            var LaLista = new List<Profesor>(); // La caja contenedora
            

            ProfexHoras ProfeHora1 = new ProfexHoras
                ("Juan", "Flores", "Manta", "131551434");          

            ProfexContrato ProfeContrato1 = new ProfexContrato
                ("Elías", "Cantos", "Montecirti", "131465431");

            ProfexNombra ProfeNombra1 = new ProfexNombra
                ("Ulices", "Rivadeneira", "Guayaquil", "13158901941");

            LaLista.Add(ProfeHora1);
            LaLista.Add(ProfeContrato1);
            LaLista.Add(ProfeNombra1);

            foreach (var a in LaLista)
            {   
                int r =a.CalcularSueldo(400, 2, 160);
                a.Imprimir();
                Console.WriteLine("Su sueldo es de Bellezaaaaaaaaaaaaaaa: $" + r);
                Console.ReadKey();
                Console.Clear();  
            }
            Console.ReadKey();
        }
 

    }
}
