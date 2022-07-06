/* 
 * Programa que le pide al usuario un carácter y comprueba si es una
 * letra minúscula o no usando booleanos. 
 * También muestra por pantalla el valor numérico del carácter introducido.
 */ 
 
using System;

class Ejercicio_03c_05
{
	static void Main()
	{
		char letra;
		bool esMinuscula;
		
		Console.WriteLine("Introduce un carácter:");
		letra = Convert.ToChar(Console.ReadLine());
		
		esMinuscula = letra >= 'a' && letra <= 'z';
		
		if (esMinuscula)
		{
			Console.WriteLine("Es una letra minúscula");
		}
		else
		{
			Console.WriteLine("No es una letra minúscula");
		}
		
		Console.WriteLine("Código numérico: {0}", (int)letra);
	}
}
