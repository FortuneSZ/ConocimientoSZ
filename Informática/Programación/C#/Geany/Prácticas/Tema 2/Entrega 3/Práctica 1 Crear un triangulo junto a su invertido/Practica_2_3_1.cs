/*Este programa creara un triangulo en base a la altura suministrada por el 
usuario,y en la misma linea un triangulo invertido */
using System;
class practica_2_3_1
{
	
	static void Main()
	{	
		int altura;
		Console.WriteLine("dime un lado del triangulo");
		altura = Convert.ToInt32(System.Console.ReadLine());
		
		for (int i=1 ;i<=altura;i++ )
		{
			for( int j=1;j<=i;j++)
			{
				Console.Write("*");
			}
			for( int j=1;j<=altura-i;j++)
			{
				Console.Write("  ");
			}
			for (int x=1;x<=i;x++)
			{
				Console.Write("*");
			}	
			Console.WriteLine();
		}		
	}
}
