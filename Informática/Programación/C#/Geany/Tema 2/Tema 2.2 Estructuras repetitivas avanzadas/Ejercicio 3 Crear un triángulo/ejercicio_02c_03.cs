/*Este programa creara un triangulo en base a la altura suministrada por el 
usuario */
using System;
class ejercicio_02c_03
{
	
	static void Main()
	{	
		int altura;
		Console.WriteLine("dime un lado del triangulo");
		altura = Convert.ToInt32(System.Console.ReadLine());
		
		for (int i=1 ;i<=altura;i++  )
		{
			for( int j=1;j<=i;j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}		
	}
}
