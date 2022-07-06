/*Este programa creará un cuadrado en la consola en base al lado dado por
el usuario */
using System;
class ejercicio_02c_02
{

	static void Main()
	{
		int lado;
		Console.WriteLine("dime el lado del cuadrado");
		lado = Convert.ToInt32(System.Console.ReadLine());

		for (int i = 1; i <= lado; i++)
		{
			for (int j = 1; j <= lado; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
