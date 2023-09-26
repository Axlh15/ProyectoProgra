using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //este rectangulo se queda con sus valores default
            Rectangulo rect1 = new Rectangulo();
            rect1.describir();
            float area1 = rect1.calcArea();
            Console.WriteLine("Area = " + area1);

            //a este se le cambio la altura
            Rectangulo rect2 = new Rectangulo();
            rect2.setAlto(12);
            rect2.describir();
            float area2 = rect2.calcArea();
            Console.WriteLine("Area = " + area2);

            //Construyo un rectangulo definiendo los valores desde el constructor
            Rectangulo rect3 = new Rectangulo(3,2);
            rect3.describir();
            float area3 = rect3.calcArea();
            Console.WriteLine("Area = " + area3);


            Triangulo triang1 = new Triangulo(2,4,6);
            triang1.describirt();
            float perm1 = triang1.calcPerimetro();
            Console.WriteLine("Perimetro = " + perm1);

            Triangulo triang2 = new Triangulo(5, 3, 8);
            triang2.describirt();
            float perm2 = triang2.calcPerimetro();
            Console.WriteLine("Perimetro = " + perm2);

            Circulo circ1 = new Circulo(5);
            double permc1 = circ1.calcPerimetroC();
            Console.WriteLine("Perimetro = " + permc1);

            Circulo circ2 = new Circulo(7);
            double permc2 = circ2.calcPerimetroC();
            Console.WriteLine("Perimetro = " + permc2);

            Producto pro1 = new Producto(5);
            pro1.describirpr();
            double priva1 = pro1.obtPrecio();
            Console.WriteLine("Precio = " + priva1);

            Zapato zap1 = new Zapato(4,"verde");
            zap1.describirz();

            Persona per1 = new Persona(2003, 2023);
            float age1 = per1.obtEdad();
            Console.WriteLine("Edad = " + age1);

            Email em1 = new Email("apuntes","programacion es una materia de...", "Angel");
            zap1.describirz();


            Console.ReadLine();
        }
    }
}
