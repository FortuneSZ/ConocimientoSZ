/* 
 * Programa que le pide al usuario dos números y le dice si ambos 
 * son pares o no, usando booleanos
 */

using System;

class Ejercicio_03c_06
{
	static void Main()
	{
		int num1, num2;
		bool sonPares;

		Console.WriteLine("Escribe dos números:");
		num1 = Convert.ToInt32(Console.ReadLine());
		num2 = Convert.ToInt32(Console.ReadLine());

		/*
		if (num1 % 2 == 0 && num2 % 2 == 0)
		{
			sonPares = true;
		}
		else
		{
			sonPares = false;
		}
		*/

		sonPares = num1 % 2 == 0 && num2 % 2 == 0;

		if (sonPares)
		{
			Console.WriteLine("Son pares los dos");
		}
		else
		{
			Console.WriteLine("No son pares los dos");
		}
	}
}
