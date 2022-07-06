/*
 * Programa que suma todos los números que recibe por línea de comandos
 */
  
using System;

class suma
{		
	static void Main(string[] args)
	{
		int resultado = 0;
		
		if (args.Length == 0)
		{
			Console.WriteLine("Error: se esperaba algún número");
		}
		else
		{
			for(int i = 0; i < args.Length; i++)
			{
				resultado = resultado + Convert.ToInt32(args[i]);
			}
			
			Console.WriteLine("Resultado = {0}", resultado);
		}
	}
}
