/* 
 * Programa que le pide al usuario su edad y año de nacimiento controlando
 * posibles errores. Si la edad es incorrecta, no le pide el año.
 */

using System;

class Ejercicio_02d_01
{
	static void Main()
	{
		int edad, nacimiento;

		try
		{
			Console.WriteLine("Dime tu edad:");
			edad = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Dime tu año de nacimiento:");
			nacimiento = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Tienes {0} años y naciste en {1}",
				edad, nacimiento);
		}
		catch (Exception e)
		{
			Console.WriteLine("Error al leer el número");
			Console.WriteLine(e.Message);
		}

		Console.WriteLine("Fin del programa");
	}
}
