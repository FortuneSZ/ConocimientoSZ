/*
 * Programa que muestra todos los números abundantes
 * hasta uno N dado por el usuario
 */
using System;

class Repaso1_8
{
	static void Main()
	{
		int n, sumaDivisores;
		
		Console.WriteLine("Introduce el valor de N:");
		n = Convert.ToInt32(Console.ReadLine());
		
		for(int num = 1; num <= n; num++)
		{
			// Detectar si num es abundante
			
			sumaDivisores = 0;
			for(int i = 1; i < num; i++)
			{
				if (num % i == 0)
				{
					sumaDivisores = sumaDivisores + i;
				}
			}
			
			if (sumaDivisores > num)
			{
				Console.WriteLine(num);
			}
		}
	}
} 
