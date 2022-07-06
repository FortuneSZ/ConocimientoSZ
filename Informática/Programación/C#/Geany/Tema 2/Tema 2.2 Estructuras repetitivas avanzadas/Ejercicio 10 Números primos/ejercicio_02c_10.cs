/*este programa le pedira al usuario un numero y le dira si es primo o no */
using System;
class ejercicio_02c_10
{
	
	static void Main()
	{	
		int numero,divisores=0;
		
		Console.WriteLine("escriba un numero");
		numero = Convert.ToInt32(System.Console.ReadLine());
		
		for(int y=2;y<numero;y++)
		{
			if (numero%y==0)
			{
				divisores++;
			}
		}
		if (divisores==0)
		{
			Console.WriteLine("es primo");
		}
		if (divisores!=0)
		{
				Console.WriteLine("no es primo");
		}
	}
}
