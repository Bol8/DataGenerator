using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGenerator.Factorias;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var factoria = new FactoriaNombrePersona();
            var factoriaApellidos = new FactoriaApellidos();


            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Nombre: "
                                  +  factoria.obtenerNombre() 
                                  + " " + factoriaApellidos.obtenerApellidos()
                                  + "\n");
              
                
                // Console.WriteLine("Apellidos: " + factoriaApellidos.obtenerApellidos() + "\n");
            }
            
            Console.ReadLine();

        }
    }
}
