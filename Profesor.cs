using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulacionExamen
{
     class Profesor
    {
        String nombres;
        String apellidos;
        String direccion;
        String cedula;

        public  Profesor(String nombres, String apellidos, String direccion,String cedula)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
            this.Cedula = cedula;
            }

        public void Imprimir()
        {
            Console.WriteLine("\n");
            Console.WriteLine(" Nombres: " + nombres +
                            "\n Apellidos: " + apellidos + 
                            "\n Dirección: " + direccion + 
                            "\n Cédula : " + cedula);   
        }

        public virtual int CalcularSueldo(int hola, int chao, int quetal) {
            int vacio = 0; 
            Console.WriteLine("Esto no debería imprimirse nunca");
            return vacio;
        }

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Cedula { get => cedula; set => cedula = value; }
    }
}

