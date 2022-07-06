/*Este programa pedirá 2 numeros al usuario y mostrará por pantalla su maximo
comun divisor */
using System;
class ejercicio_02c_05
{
	
	static void Main()
	{	
		int numero1,numero2,mcd=0;
		
		Console.WriteLine("dime el primer número ");
		numero1 = Convert.ToInt32(System.Console.ReadLine());
		
		Console.WriteLine("dime el segundo número ");
		numero2 = Convert.ToInt32(System.Console.ReadLine());
		
		if (numero1 < numero2)
		{
			for (int y=numero1;y>=0;y--)
			{
					if (y==1)
				{
					Console.WriteLine("no hay maximo comun divisor");
					break;
				}
				if (numero1%y==0 && numero2%y==0)
				{
					mcd=y;
					Console.WriteLine("el maximo comun divisor de" +
					" {0} y {1} es {2}",numero1,numero2,y);
					break;
				}
			}		
			
		}
		if (numero1 > numero2)
		{
			for (int y=numero2;y>=0;y--)
			{
				if (y==1)
				{
					Console.WriteLine("no hay maximo comun divisor");
					break;
				}
				if (numero1%y==0 && numero2%y==0)
				{
					Console.WriteLine("el maximo comun divisor de" +
					" {0} y {1} es {2}",numero1,numero2,y);
					break;
				}
				if (numero1%y!=0 && numero2%y!=0 && y==0) 
				{
					Console.WriteLine("no hay maximo comun divisor");
				}
			}
		}		
	}	
}
