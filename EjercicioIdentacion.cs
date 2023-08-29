/*
INSTRUCCIONES

1. En cada una de las líneas del siguiente código
deberás colocar un comentario al final de la línea en el que 
indiques  el nivel de identación de la siguiente manera: //Identacion: #
donde # es el nivel de identación.

2. Adicional al nivel de identación, en cada línea donde 
haya una llave de apertura deberás colocar un comentario 
que diga: //Inicio de bloque ... 
donde los 3 puntos indican a qué le pertenece, por ejemplo:
inicio de bloque de metodo1, inicio de bloque de claseA, 
inicio de ciclo for, etc.
Y, donde haya una llave de cierre, deberás colocar lo mismo, 
pero indicando //Fin de bloque ...

Observa algunas líneas de ejemplo que ya lo tienen.
Debes hacerlo para cada una de las líneas, excepto las que 
estén vacías.
*/
using System;//Identacion: 0

namespace ClasesYMetodosAnidados//Identacion: 0
{//Identacion: 0, Inicio de bloque de namespace ClasesYMetodosAnidados
	class Program //Identacion: 1
	{//Identacion: 1, Inicio de bloque de class Program
		static void Main(string[] args)//identacion: 2
		{//Identacion: 2, Inicio de bloque de metodo static void Main(string[] args)
			ClaseA objetoA = new ClaseA();//Identacion: 3
			ClaseB objetoB = new ClaseB();//Identacion 3

			objetoA.Metodo1();//Identacion: 3
			objetoA.Metodo2();//Identacion: 3

			objetoB.Metodo1();//Identacion: 3
			objetoB.Metodo2();//Identacion: 3
		}//Identacion: 2, Fin de bloque de metodo static void Main(string[] args)
	}//Identacion: 1, Fin de bloque de class Program

	class ClaseA //Identacion: 1
	{//Identacion: 1, Inicio de bloque de class ClaseA 
		public void Metodo1()//Identacion: 2
		{//Identacion: 2, Inicio de bloque de metodo public void Metodo1()
			for (int i = 0; i < 3; i++)//Identacion: 3
			{//Identacion: 3, Inicio de bloque de ciclo for 
				Console.WriteLine("Método 1 de ClaseA - Iteración: " + i);//Identacion: 4

				for (int j = 0; j < 2; j++)//Identacion: 4
				{//Identacion: 4, Inicio de bloque de ciclo for
					Console.WriteLine("Ciclo anidado - Iteración: " + j);//Identacion: 5
				}//Identacion: 4, Fin de bloque de ciclo for
			}//Identacion: 3, Fin de bloque de ciclo for
		}//Identacion: 2, Fin de bloque de metodo public void Metodo1()

		public void Metodo2()//Identacion: 2
		{//Identacion: 2, Inicio de bloque de metodo public void Metodo2()
			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)//Identacion: 3
			{//Identacion: 3, Inicio de bloque de ciclo if
				Console.WriteLine("Es fin de semana en Método 2 de ClaseA");//Identacion: 4
			}//Identacion: 3, Fin de bloque de ciclo if
			else//Identacion: 3
			{//Identacion: 3, Inicio de bloque de ciclo else
				Console.WriteLine("No es fin de semana en Método 2 de ClaseA");//Identacion: 4
			}//Identacion: 3, Fin de bloque de ciclo else
		}//Identacion: 2, Fin de bloque de metodo public void Metodo2()
	}//Identacion: 1, Fin de bloque de class Clase A

	class ClaseB//Identacion: 1
	{//Identacion: 1, Inicio de bloque de class Clase B
		public void Metodo1()//Identacion: 2
		{//Identacion: 2, Inicio de bloque de metodo public void metodo1()
			for (int i = 5; i > 0; i--)//Identacion: 3
			{//Identacion: 3, Inicio de bloque de ciclo for
				Console.WriteLine("Método 1 de ClaseB - Iteración: " + i);//Identacion: 4

				for (int j = 0; j < i; j++)//Identacion: 4
				{//Identacion: 4, Inicio de bloque de ciclo for
					Console.WriteLine("Ciclo anidado - Iteración: " + j);//Identacion: 5
				}//Identacion: 4, Fin de bloque de ciclo for
			}//Identacion: 3, Fin de bloque de ciclo for
		}//Identacion: 2, Fin de bloque de metodo public void metodo1()

		public void Metodo2()//Identacion: 2
		{//Identacion: 2, Inicio de bloque de metodo public void Metodo2()
			int numero = 10;//Identacion: 3

			if (numero % 2 == 0)//Identacion: 3
			{//Identacion: 3, Inicio de bloque de ciclo if
				Console.WriteLine("El número es par en Método 2 de ClaseB");//Identacion: 4
			}//Identacion: 3, Fin de bloque de ciclo if
			else//Identacion: 3
			{//Identacion: 3, Inicio de bloque de ciclo else
				Console.WriteLine("El número es impar en Método 2 de ClaseB");//Identacion: 4
			}//Identacion: 3, Fin de bloque de ciclo else
		}//Identacion: 2, Fin de bloque de metodo public void metodo2()
	}//Identacion: 1, Fin de bloque de class ClaseB
}//Identacion: 0, Fin de bloque de namespace ClasesYMetodosAnidados