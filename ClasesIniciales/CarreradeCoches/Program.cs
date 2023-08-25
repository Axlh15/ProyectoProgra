using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreradeCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto Ferrari = new Auto();
            Ferrari.Modelo = "Ferrari F1";
            Ferrari.Velocidad = 120;

            Auto mclaren = new Auto();
            mclaren.Modelo = "Ferrari F1";
            mclaren.Velocidad = 140;

            PistadeCarrera pista1 = new PistadeCarrera();
            pista1.nombre = "hermanos rpdriguez";
            pista1.longitud = 4.303f;//son km

            pista1.Competir(Ferrari, mclaren);

            //esta linea espera que presione enter para continuar
            Console.ReadLine();
            
        }
    }
}
