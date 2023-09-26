using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConstructores
{
    public class Rectangulo
    {
        //valores default
        private float ancho = 5;
        private float alto = 10;

        //este es un constructo
        //default
        public Rectangulo()
        {

        }

        //Consutructor que si recibe parámetros
        public Rectangulo(float valorAncho, float valorAlto)
        {//Establezco el estado inicial del objeto
            ancho = valorAncho;
            alto = valorAlto;
        }


        public void describir()// escribe pero no devuelve nada
        {
            Console.WriteLine("Rectangulo " + ancho + "x" + alto);
        
        }

        public float calcArea()
        {
            float area = alto * ancho;
            return area;// no puede haber lineas por debajo de return, return termina
        }

        public void setAlto(float valor)
        {
            alto = valor;
            
        
        }
    }

}
