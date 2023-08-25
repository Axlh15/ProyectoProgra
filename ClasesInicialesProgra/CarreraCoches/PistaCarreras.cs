using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraCoches
{
    public class PistaCarreras
    {
        public string nombre;
        public float longitud;

        //metodo que recibe dos parametros
        public void Competir (Auto auto1, Auto auto2)
        { //bloque del metodo

            Console.WriteLine("Iniciando competencia entre" + auto1.modelo + " contra " + auto2.modelo);

            if (auto1.velocidad > auto2.velocidad)
            {
                Console.WriteLine("Ganó" + auto1.modelo);
            }
            else if (auto2.velocidad > auto1.velocidad)
            {
                Console.WriteLine("Ganó" + auto2.modelo);
            }
            else
            {
                Console.WriteLine("Hubo un empate");
            }
        }
    }
}
