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
            var factoria = new FactoriaNombrePersona(3);


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Nombre: " + factoria.obtenerNombre() + "\n");
            }


        }
    }
}
