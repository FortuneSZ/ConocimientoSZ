/* 
 * Programa que le pide al usuario dos datos de tipo byte y los
 * multiplica en otra variable
 */

using System;

class Ejercicio_03a_01
{
	static void Main()
	{
		byte num1, num2;
		int resultado;

		Console.WriteLine("Escribe dos números:");
		num1 = Convert.ToByte(Console.ReadLine());
		num2 = Convert.ToByte(Console.ReadLine());

		resultado = num1 * num2;
		Console.WriteLine(resultado);
	}
}
