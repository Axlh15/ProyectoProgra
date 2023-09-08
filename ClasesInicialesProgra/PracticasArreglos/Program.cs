using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ciudades = { "Osaka", "Tokyo", "Seoul", "Puebla", "Montreal", "Paris", "Londres", "Buenos Aires"};//arreglo explicito 

            //Obtener longitud del arreglo
            int cantElems = ciudades.Length;
            Console.WriteLine("El arreglo tiene " + cantElems + " elementos");

            //Acceder a los elementos del arreglo
            string ciudad1 = ciudades[1];
            string ciudad4 = ciudades[4];

            Console.WriteLine(ciudad1);
            Console.WriteLine(ciudad4);
            Console.WriteLine(ciudades[0]);
            Console.WriteLine(ciudades[5]);

            //Modificar elementos de un arreglo
            ciudades[4] = "Otawa";
            Console.WriteLine(ciudades[4]);

            for(int i = 0; i < 8; i++)
            {//esta hardcodeado el 8 :C, no se adapta y vale cheto el codigo (si es menor la cantidad de elementos a lo hardcodeado crashea, si es mayor no los muestra )

            }
            //variable de control, condición, modificación (modificar la variable control de uno en uno)
            for(int i = 0; i < ciudades.Length; i++)
            {   //Parametrizado :D si se adapta conforme se vaya ejecutando el programa
                Console.WriteLine(i + ".-" + ciudades[i]);
            }


            Console.Read();
        }
    }
}
