/* 
 * Programa que le pide al usuario su login y 
 * su password repetido hasta que los passwords coincidan
 */

using System;

class Ejercicio_03c_04
{
	static void Main()
	{
		string login, password1, password2;

		Console.WriteLine("Introduce el login:");
		login = Console.ReadLine();

		do
		{
			Console.WriteLine("Introduce el password:");
			password1 = Console.ReadLine();
			Console.WriteLine("Confirma el password:");
			password2 = Console.ReadLine();

			if (password1 != password2)
			{
				Console.WriteLine("Los passwords no coinciden");
			}
		}
		while (password1 != password2);

		Console.WriteLine("Acceso permitido.");
	}
}
