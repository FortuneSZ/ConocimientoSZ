/*
 * Programa que le pide al usuario un número largo en formato string
 * y le dice si es binario o no
 */
using System;

class Repaso1_5
{
	static void Main()
	{
		string numero;
		bool esBinario = true;
		
		Console.WriteLine("Escribe el número:");
		numero = Console.ReadLine();
		
		foreach(char digito in numero)
		{
			if (digito != '0' && digito != '1')
				esBinario = false;
		}
		
		if (esBinario)
		{
			Console.WriteLine("Es binario");
		}
		else
		{
			Console.WriteLine("No es binario");
		}
	}
} 
