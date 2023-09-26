using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConstructores
{
    public class Persona
    {
        private float añoNacimiento = 2003;
        private float añoActual = 2023;

        public Persona(float valorNacimiento, float valorActual)
        {
            añoNacimiento = valorNacimiento;
            añoActual = valorActual;

        }



        public float obtEdad()
        {
            float edad = añoActual - añoNacimiento;
            return edad;
        }

    }
}
