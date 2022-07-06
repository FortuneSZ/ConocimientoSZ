/* 
 * Programa que le pide al usuario números enteros y
 * muestra su valor en binario y hexadecimal hasta
 * que escribe 0
 */

using System;

class Ejercicio_03a_04
{
	static void Main()
	{
		int numero;

		Console.WriteLine("Escribe números. 0 para finalizar");

		do
		{
			numero = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Binario: {0}", Convert.ToString(numero, 2));
			Console.WriteLine("Hexadecimal: {0}", Convert.ToString(numero, 16));
		}
		while (numero != 0);
	}
}
