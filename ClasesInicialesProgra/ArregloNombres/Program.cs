using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flower Child Name");
            NombresGenerador childName = new NombresGenerador();

            childName.generar(6, 1, 8);

            Console.ReadLine();
        }
    }
}
