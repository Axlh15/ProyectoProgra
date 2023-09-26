using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConstructores
{
    public class Circulo
    {
        private double diametro = 4;

        public Circulo(double valorDiametro)
        {
            diametro = valorDiametro;

        }

        public double calcPerimetroC()
        {
            double perimetroC = diametro * Math.PI;
            return perimetroC;

        }
    }
}
