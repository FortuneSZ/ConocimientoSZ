/* 
 * Programa que le pide al usuario dos datos enteros (int)
 * de 5 o 6 cifras y los multiplica
 */

using System;

class Ejercicio_03a_03
{
	static void Main()
	{
		int num1, num2, resultado;
		int prueba = 2147483647;

		Console.WriteLine("Escribe dos números:");
		num1 = Convert.ToInt32(Console.ReadLine());
		num2 = Convert.ToInt32(Console.ReadLine());

		resultado = num1 * num2;
		Console.WriteLine(resultado);

		prueba++;
		Console.WriteLine("Prueba = {0}", prueba);
	}
}
