using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraCoches
{
    public class Program
    {
        static void Main(string[] args)
        {
            Auto ferrari = new Auto();
            ferrari.modelo = " FerrariF1 ";
            ferrari.velocidad = 120;

            Auto mclaren = new Auto();
            mclaren.modelo = " MC 2443 ";
            mclaren.velocidad = 140; //km/h

            PistaCarreras pista1 = new PistaCarreras();
            pista1.nombre = " Hermanos Rodriguez ";
            pista1.longitud = 4.303f; //km

            ferrari.acelerar(50);
            ferrari.ponergasolina(10);
            ferrari.arrancar(); //invocaciòn de metodo/ usar metodo

            mclaren.frenar();
            mclaren.arrancar();

            pista1.Competir(ferrari, mclaren);

            //esta linea espera que presiones enter para continuar
            Console.ReadLine();
        }
    }
}
