/* 
 * Programa que calcula la raíz cuadrada del número que
 * diga el usuario, usando typecast y tipo float
 */

using System;

class Ejercicio_03b_06
{
	static void Main()
	{
		float numero, raiz;

		Console.WriteLine("Escribe un número:");
		numero = Convert.ToSingle(Console.ReadLine());

		raiz = (float)Math.Sqrt(numero);
		Console.WriteLine(raiz);

		// Console.WriteLine((float)Math.Sqrt(numero)); 
	}
}
