/* 
 * Programa que define una función recursiva que calcula la potencia
 * de una base elevada a un exponente
 */ 
 
using System;

class Ejercicio_05c_04
{		
	static int CalcularPotencia(int b, int e)
	{
		if (e == 0)
		{
			return 1;
		}
		else if (e == 1)
		{
			return b;
		}
		else
		{
			return b * CalcularPotencia(b, e-1);
		}
	}
	
    static void Main()
    {
		Console.WriteLine(CalcularPotencia(7, 3));
		Console.WriteLine(CalcularPotencia(4, 5));
    }
}
