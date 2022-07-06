/* 
 * Programa que le pide al usuario su edad y año de nacimiento controlando
 * posibles errores. Si la edad es incorrecta, le pide el año de todas formas
 */

using System;

class Ejercicio_02d_01b
{
	static void Main()
	{
		int edad = -1, nacimiento = -1;

		try
		{
			Console.WriteLine("Dime tu edad:");
			edad = Convert.ToInt32(Console.ReadLine());
		}
		catch (Exception e)
		{
			Console.WriteLine("Edad incorrecta");
			Console.WriteLine(e.Message);
		}

		try
		{
			Console.WriteLine("Dime tu año de nacimiento:");
			nacimiento = Convert.ToInt32(Console.ReadLine());
		}
		catch (Exception e)
		{
			Console.WriteLine("Año de nacimiento incorrecto");
			Console.WriteLine(e.Message);
		}

		if (edad != -1 && nacimiento != -1)
		{
			Console.WriteLine("Tienes {0} años y naciste en {1}",
				edad, nacimiento);
		}

		Console.WriteLine("Fin del programa");
	}
}
