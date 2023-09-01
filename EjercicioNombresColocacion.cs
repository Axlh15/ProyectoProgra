/*
En este ejercicio practicarás el nombre de las cosas
y su ubicación dentro del código.
Por cada línea que tenga una declaración de namespace,
clase, método, atributo, parámetro, variable, así como 
en ciclos y bloques condicionales, deberás indicar con un comentario 
qué es lo que se está declarando y dentro de qué bloque está.

No copies y pegues, debes transcribir.
NO: class Elefante
SI: clase Elefante

Observa con atención los primeros ejemplos.
*/

using System;//El using no es una declaración

namespace Ejemplos//Declaración de espacio de nombres Ejemplos
{
    class Elefante//Declaración de clase Elefante dentro de namespace Ejemplos
    {
        public string Nombre;//Declaración de atributo Nombre dentro de clase Elefante
        public int Edad;//Declaración de atributo Edad dentro de clase Elefante
        public float Peso;//Declaración de atributo Peso dentro de clase Elefante

        //Declaración de método Comer dentro de clase Elefante
        //Declaración de parámetro comida dentro de método comer
        public void Comer(string comida)
        {
            
            for(int i = 0; i < 10; i++)//Ciclo for dentro de método Comer
            {
                int porcionesComidas = i + 1;//Declaración de variable local porcionesComidas dentro de ciclo for
            }
            Console.WriteLine($"{Nombre} está comiendo {comida}.");//Esta línea no llevará comentario
        }
        //Declaración de método Rugir dentro de clase Elefante
        public void Rugir()
        {
            int distanciaEscuchante = 100;//Declaración de variable local distanciaEscuchante dentro de método Rugir
            Console.WriteLine($"{Nombre} está rugiendo.");
        }
        //Declaración de método Dormir dentro de clase Elefante
        //Declaración de parámetro horas dentro de método Dormir
        public void Dormir(int horas)
        {
            if(horas > 10)//Declaración de Bloque condicional if dentro de método Dormir
            {
                float energiaGanada = 15;//Declaración de variable local energiaGanada dentro de bloque condicional if
            }
            Console.WriteLine($"{Nombre} está durmiendo durante {horas} horas.");
        }
    }

    class Zapatero//Declaración de clase Zapatero dentro de namespace Ejemplos
    {
        public string Nombre;//Declaración de atributo Nombre dentro de clase Zapatero
        public string Especialidad;//Declaración de atributo Especialidad dentro de clase Zapatero
        public int AñosExperiencia;//Declaración de atributo AñosExperiencia dentro de clase Zapatero

        //Declaración de método RepararZapatos dentro de clase Zapatero
        //Declaración de parámetros tipo y cantidad dentro de método RepararZapatos
        public void RepararZapatos(string tipo, int cantidad)
        {
            int precio = 50;//Declaración de variable local precio dentro de método RepararZapatos
            if (tipo == "tenis") //Declaración de bloque condicional if dentro de método RepararZapatos
            {
                precio = 100;
            }
            Console.WriteLine($"{Nombre} está reparando {cantidad} zapatos de tipo {tipo} a precio {precio}");
        }

        //Declaración de método CrearZapato dentro de clase Zapatero
        //Declaración de parámetros estilo y material dentro de método CrearZapato
        public void CrearZapato(string estilo, string material)
        {
            for(int i = 0; i < 100; i++)//Declaración de ciclo for dentro de método CrearZapato
            {
                if(estilo == "industrial")//Declaración de bloque condicional if dentro de ciclo for
                {
                    Console.WriteLine("Golpeando fuerte");
                }
                else //Declaración de bloque condicional else dentro de ciclo for
                {
                    Console.WriteLine("Golpeando normal");

                }
            }
            Console.WriteLine($"{Nombre} está creando un zapato de estilo {estilo} con material {material}.");
        }

        //Declaración de método MedirPie dentro de clase Zapatero
        //Declaración de parámetro numeroPie dentro de método MedirPie
        public void MedirPie(int numeroPie)
        {
            string cliente;//Declaración de atributo cliente dentro de método MedirPie
            if (numeroPie > 20) //Declaración de bloque condicional if dentro de método MedirPie
            {
                cliente = "Adulto";
            }
            else//Declaración de bloque condicional else dentro de método MedirPie
            {
                cliente = "Niño";
            }
            Console.WriteLine($"{Nombre} está midiendo el pie para el número {numeroPie}.");
        }
    }

    //Declaración de clase Television dentro de namespace Ejemplos
    class Television
    {
        public string Marca;//Declaración de atributo Marca dentro de clase Television
        public int Pulgadas;//Declaración de atributo Pulgadas dentro de clase Television
        public bool Encendida;//Declaración de atributo Encendida dentro de clase Television

        //Declaración de método Encender dentro de clase Television
        public void Encender()
        {
            Encendida = true;
            float consumoLuz = 0.05f;//Declaración de variable local dentro de método Encender
            Console.WriteLine($"La televisión de {Pulgadas} pulgadas, marca {Marca}, está encendida.");
        }

        //Declaración de método CambiarCanal dentro de clase Television
        //Declaración de parámetro canal dentro de método CambiarCanal
        public void CambiarCanal(int canal)
        {
            for(int i = 1; i < canal; i++)//Declaración de ciclo for dentro de método CambiarCanal
            {
                Console.WriteLine($"Cambiando a canal {i}.");
            }            
        }

        //Declaración de método AjustarVolumen dentro de clase Television
        //Declaración de parámetro nivel dentro de método AjustarVolumen
        public void AjustarVolumen(int nivel)
        {
            if (nivel > 100)//Declaración de bloque condicional if dentro de método AjustarVolumen
            {
                nivel = 0;
            }
            Console.WriteLine($"Ajustando el volumen a nivel {nivel}.");
        }
    }

    //Declaración de clase Guitarra dentro de namespace Ejemplos
    class Guitarra
    {
        public string Marca;//Declaración de atributo Marca dentro de clase Guitarra
        public string Tipo;//Declaración de atributo Tipo dentro de clase Guitarra
        public int Cuerdas;//Declaración de atributo Cuerdas dentro de clase Guitarra

        //Declaración de método TocarCuerda dentro de clase Guitarra
        //Declaración de parámetro numeroCuerda dentro de método TocarCuerda
        public void TocarCuerda(int numeroCuerda)
        {
            if(numeroCuerda == 6)//Declaración de bloque condicional if dentro de método TocarCuerda
            {
                string nota = "Mi";//Declaración de variable local dentro del bloque condicional if
            }
            else if (numeroCuerda == 5)
            {
                string nota = "La";//Declaración de variable local dentro de bloque condicional if
            }
            Console.WriteLine($"Tocando la cuerda {numeroCuerda} de la guitarra {Marca}.");
        }

        //Declaración de método AfinarGuitarra dentro de clase Guitarra
        //Declaración de parámetro afinada dentro de método AfinarGuitarra
        public void AfinarGuitarra(bool afinada)
        {
            if (afinada) //Declaración de bloque condicional if dentro de método AfinarGuitarra
            {
                Console.WriteLine($"La guitarra {Marca} está afinada.");
            }
            else//Declaración de bloque condicicional else dentro de método AfinarGuitarra
            {
                for(int i = 0; i < 5; i++)//Declaración de ciclo for dentro de bloque condicional else 
                {
                    Console.WriteLine($"Afinando la guitarra {Marca}.");
                }                
            }
        }

        //Declaración de método CambiarTipo dentro de clase Guitarra
        //Declaración de parámetro nuevoTipo dentro de método CambiarTipo
        public void CambiarTipo(string nuevoTipo)
        {
            Tipo = nuevoTipo;
            Console.WriteLine($"Cambiando el tipo de la guitarra a {nuevoTipo}.");
        }
    }

}
