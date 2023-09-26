using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConstructores
{
    public class Producto
    {
        private double precio = 3.0;

        public Producto(double valorPrecio)
        {
            precio = valorPrecio;

        }

        public void describirpr()// escribe pero no devuelve nada
        {
            Console.WriteLine("Precio " + precio + "+" + "IVA");

        }

        public double obtPrecio()
        {
            double precioIva = precio + precio*0.16;
            return precioIva;

        }
    }
}
