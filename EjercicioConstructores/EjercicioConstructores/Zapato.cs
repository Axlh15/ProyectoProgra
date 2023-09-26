using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConstructores
{
    public class Zapato
    {
        private float talla = 5 ;
        private string color = "rojo";

        public Zapato(float valorTalla, string tonoColor)
        {
            talla = valorTalla;
            color = tonoColor;
        }

        public void describirz()// escribe pero no devuelve nada
        {
            Console.WriteLine("zapato " + "talla " + talla + " color " + color);

        }

       
    }
}
