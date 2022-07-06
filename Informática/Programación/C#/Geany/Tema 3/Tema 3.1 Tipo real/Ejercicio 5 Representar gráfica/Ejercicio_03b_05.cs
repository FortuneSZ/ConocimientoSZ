/*Este programa representará la función (x-5) al cuadrado con asteriscos */
using System;
class Ejercicio_03b_05
{
	
	static void Main()
	{	
		for (int x=1 ;x<=10;x++ )
		{
			int y= (x-5)* (x-5);
			Console.Write(" {0} ",y);
		}
		Console.WriteLine();
		Console.WriteLine("grafica");
		for (int x=1 ;x<=10;x++ )
		{
			int y= (x-5)* (x-5);
			for (int n=0;n<y;n++)
			{
				Console.Write(" ");
			}
			Console.WriteLine("*");
		}
	}
}
