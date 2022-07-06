/*este programa le pedira al usuario que adivine un numero del o al 100
previamente fijado en el codigo */
using System;
class ejercicio_02c_09
{

	static void Main()
	{
		int numero;

		do
		{
			Console.WriteLine("escriba un numero del 1 al 100");
			numero = Convert.ToInt32(System.Console.ReadLine());
			if (numero < 11)
			{
				Console.WriteLine("fallaste,te quedaste corto");
			}

			if (numero > 11)
			{
				Console.WriteLine("fallaste,te pasaste");
			}
		}
		while (numero != 11);

		if (numero == 11)
		{
			Console.WriteLine("acertaste");
		}


	}
}
