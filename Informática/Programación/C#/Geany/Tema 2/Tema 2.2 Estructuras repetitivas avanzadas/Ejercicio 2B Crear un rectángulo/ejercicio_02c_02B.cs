/*Este programa creará un rectangulo en base a los 2 lados proporcionados
por el usuario */
using System;
class ejercicio_02c_02B
{
	
	static void Main()
	{	
		int ladox,ladoy;
		Console.WriteLine("dime un lado del rectangulo");
		ladox = Convert.ToInt32(System.Console.ReadLine());
		Console.WriteLine("dime otro lado del rectangulo");
		ladoy = Convert.ToInt32(System.Console.ReadLine());
		
		for (int i=1 ;i<=ladox;i++  )
		{
			for( int j=1;j<=ladoy;j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}		
	}
}
