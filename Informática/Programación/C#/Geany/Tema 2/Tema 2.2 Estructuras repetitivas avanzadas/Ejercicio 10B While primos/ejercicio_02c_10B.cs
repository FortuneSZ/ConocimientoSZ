/*este programa le pedira al usuario un numero y le dira si es primo o no */
using System;
class ejercicio_02c_10
{
	
	static void Main()
	{	
		int numero,divisores=0,n=2;
		
		Console.WriteLine("escriba un numero");
		numero = Convert.ToInt32(System.Console.ReadLine());
		
		while (divisores==0 && n<numero)
		{
			if (numero%n==0)
			{
				divisores++;
			}
			n++;
		}
		if (divisores ==0 && numero>1)
		{
			Console.WriteLine("es primo");
		}
		else
		{
			Console.WriteLine("no es primo");
		}

	}
}
