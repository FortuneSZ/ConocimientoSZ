/* 
 * Programa que define una función que obtiene el mayor producto de dos
 * números de un array
 */ 
 
using System;

class Repaso3_3
{		
	static int MaxProducto(int[] datos)
	{
		Array.Sort(datos);
		return Math.Max(datos[0] * datos[1],
			datos[datos.Length - 1] * datos[datos.Length - 2]);
	}
	
    static void Main()
    {
		int[] numeros = {10, 20, 40, 20};
		int[] numeros2 = {20, 40, 10, -30, -50};
		Console.WriteLine(MaxProducto(numeros));
		Console.WriteLine(MaxProducto(numeros2));
    }
}
