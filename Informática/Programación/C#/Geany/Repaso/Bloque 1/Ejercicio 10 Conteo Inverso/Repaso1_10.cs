/*
 * Programa que muestra invertido el número escrito por el usuario
 */
using System;

class Repaso1_10
{
	static void Main()
	{
		// Opcion 1
		
		long numero, numeroInvertido = 0;
		
		Console.WriteLine("Escribe un número:");
		numero = Convert.ToInt64(Console.ReadLine());
		
		while(numero > 0)
		{
			long resto = numero % 10;
			numeroInvertido *= 10;
			numeroInvertido += resto;
			// Console.Write(numero % 10);
			numero = numero / 10;
		}
		Console.WriteLine(numeroInvertido);
		
		// Opcion 2
		
		string numeroString, numeroStringInvertido = "";
		
		Console.WriteLine("Escribe un número:");
		numeroString = Console.ReadLine();
		
		foreach(char digito in numeroString)
		{
			numeroStringInvertido = digito + numeroStringInvertido;
		}
		
		Console.WriteLine(numeroStringInvertido);

	}
} 
