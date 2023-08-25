using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreradeCoches
{
    public class PistadeCarrera
    {
        public float longitud;
        public string nombre;

        public void Competir(Auto auto1, Auto auto2)
        {//esta es el bloque bdel metodo
            Console.WriteLine("iniciando competencia entre" + auto1.Modelo + "contra" + auto2.Modelo);

            if(auto1.Velocidad>auto2.Velocidad)
            {
                Console.WriteLine("gano" + auto1.Modelo);
            }
            else  if (auto2.Velocidad>auto1.Velocidad)
                {
                Console.WriteLine("gano" + auto2.Modelo);
            }
            else
            {
                Console.WriteLine("hubo un empate");
            }
        }
}
}