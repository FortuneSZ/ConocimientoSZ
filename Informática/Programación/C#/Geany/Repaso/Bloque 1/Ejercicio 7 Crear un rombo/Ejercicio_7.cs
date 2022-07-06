/*este programa creará un rombo en base al lado proporcionado por el usuario*/
using System;

class Ejercicio_7
{
	static void Main()
	{
	
		int lado,contadorespacios,contadorasteriscos;
		
		Console.WriteLine("introduzca el lado del hexagono");
		lado= Convert.ToInt32(Console.ReadLine());
		
		contadorespacios=lado;
		contadorasteriscos=lado;
		
		for(int y=0;y<lado-1;y++)
		{
			for(int x=0;x<contadorespacios;x++)
			{
				Console.Write(" ");
			}
			for(int j=0;j<contadorasteriscos;j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
			contadorasteriscos +=2;
			contadorespacios--;
		}
		for(int y=0;y<lado;y++)
		{
			
			for(int x=0;x<contadorespacios;x++)
			{
				Console.Write(" ");
			}
			for(int j=0;j<contadorasteriscos;j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
			contadorasteriscos -=2;
			contadorespacios++;
		}
	}
}
		
