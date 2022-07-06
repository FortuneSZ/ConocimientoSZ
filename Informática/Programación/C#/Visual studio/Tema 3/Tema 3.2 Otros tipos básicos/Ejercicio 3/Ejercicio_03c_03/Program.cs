/* 
 * Programa que le pide al usuario su nombre y le saluda
 * si se llama Juan
 */

using System;

class Ejercicio_03c_03
{
	static void Main()
	{
		string nombre;

		Console.WriteLine("Dime tu nombre:");
		nombre = Console.ReadLine();

		if (nombre == "Juan" || nombre == "juan" || nombre == "JUAN")
		{
			Console.WriteLine("Hola");
		}
		else
		{
			Console.WriteLine("No te conozco.");
		}
	}
}
