/*este programa le pedira al usuario que adivine un numero del o al 100
previamente fijado en el codigo en un numero de intentos */
using System;
class ejercicio_02c_09B
{
	
	static void Main()
	{	
		int numero,intentos=6;
		
		Console.WriteLine("escriba un numero del 1 al 100");
		numero = Convert.ToInt32(System.Console.ReadLine());
		
		if (numero!=11)
		{
			do
			{
			Console.WriteLine("escriba un numero del 1 al 100");
			numero = Convert.ToInt32(System.Console.ReadLine());
			if (numero!=11)
			{
				intentos--;
			}
			Console.WriteLine("numero de intentos {0}",intentos);
			
			}
			while (numero!=11 && intentos!=0);
		
			if (numero==11)
			{
				Console.WriteLine("acertaste");
			}
		
			if (intentos==0)
			{
			Console.WriteLine("fallaste");	
			}
		}
		else
		{
			Console.WriteLine("acertaste");
		}	
	}
}
