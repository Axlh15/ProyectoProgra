using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConstructores
{
    public class Triangulo
    {
        private float ladoA = 3;
        private float ladoB = 4;
        private float ladoC = 5;

        public Triangulo(float valorLadoA, float valorLadoB, float valorLadoC)
        {
            ladoA = valorLadoA;
            ladoB = valorLadoB;
            ladoC = valorLadoC;
        
        }

        public void describirt()// escribe pero no devuelve nada
        {
            Console.WriteLine("Triangulo " + ladoA + "+" + ladoB + "+" + ladoC);

        }

        public float calcPerimetro()
        {
            float perimetro = ladoA + ladoB + ladoC;
            return perimetro;
        
        }
    }
}
