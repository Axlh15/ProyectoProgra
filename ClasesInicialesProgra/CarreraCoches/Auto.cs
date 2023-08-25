using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraCoches
{
    public class Auto
    {
        public string modelo;
        public Color color;
        public float velocidad;
        public float gasolina;

        public void arrancar() //declaraciòn del metodo (crear metodo)
        {
            if (gasolina > 0) //el coche tiene gas
            {
                gasolina = gasolina - 0.1f;
            Console.WriteLine("Arrancando" + modelo + ", le queda " + gasolina + "l de gas ");
            }
            else // no tiene gas
            {
                Console.WriteLine(modelo + "no tiene gas. No se puede arrancar.");


            }
        }
        public void ponergasolina(float cantidad)
        {
            gasolina = gasolina + cantidad;
            Console.WriteLine("Se puso gas" + modelo + ". Ahora tiene " + gasolina + "l.");
        }
        public void acelerar(float aceleración)
        {
            velocidad = velocidad + aceleración;
            gasolina = gasolina - (aceleración)*.10f;
            Console.WriteLine("Se aceleró" + modelo + ". Ahora tiene " + velocidad + " de velocidad");
            
            if (gasolina <= 0) //el coche agotó el gas
            {
                Console.WriteLine("Se agotó la gasolina");

            }
        }
        public void frenar()
        {
            velocidad = 0;
            Console.WriteLine("Se frenó" + modelo + ". Ahora tiene " + velocidad + " de velocidad");
        }
    }//fin de la clase
}
