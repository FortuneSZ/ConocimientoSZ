/* 
 * Programa que le pide al usuario cuatro caracteres y los muestra
 * en orden inverso y entre comillas dobles
 */ 
 
using System;

class Ejercicio_03c_02
{
	static void Main()
	{
		char c1, c2, c3, c4;
		
		Console.WriteLine("Escribe 4 caracteres:");
		c1 = Convert.ToChar(Console.ReadLine());
		c2 = Convert.ToChar(Console.ReadLine());
		c3 = Convert.ToChar(Console.ReadLine());
		c4 = Convert.ToChar(Console.ReadLine());
		
		Console.WriteLine("\"{0}{1}{2}{3}\"", c4, c3, c2, c1);
	}
}
