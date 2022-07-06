/*vamos a/a calcular si el primer numero se puede dividir por el segundo
en caso de ser 0 especiremos que no es posible*/
using System;
class ejercicio_02a_04
{
	
	static void Main()
	{		
		int numero1,numero2;
		
		Console.WriteLine("dime el primer numero");
		numero1=Convert.ToInt32(System.Console.ReadLine());
		
		Console.WriteLine("dime el divisor");
		numero2=Convert.ToInt32(System.Console.ReadLine());
		
		if (numero2 !=0)
		{
			Console.WriteLine(numero1/numero2);
		}
		else
		{
			Console.WriteLine("No se puede dividir por 0");
		}	
	}	
}
