/* en este programa introducimos un número y vemos si es par,si lo es mostramos
 * un mensaje que dice que es par*/
using System;

class Ejercicio_02a_01
{
	static void Main()
	{
		int numero;
		Console.WriteLine("escribe un numero entero");
		numero = Convert.ToInt32(Console.ReadLine());
		
		if (numero%2==0)
		{
			Console.WriteLine("es un numero par");
		}
	}		
}
