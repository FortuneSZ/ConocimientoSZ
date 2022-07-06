/*Este programa Calculará una ecuación de segundo grado en base a los datos
introducidos por el usuario*/
using System;
class ejercicio_03b_04
{	
	static void Main()
	{	
		int a,b,c,raiz;
		double resultado;
		
		Console.WriteLine("dime el valor de a");
		a = Convert.ToInt32(System.Console.ReadLine());
		
		Console.WriteLine("dime el valor de b");
		b = Convert.ToInt32(System.Console.ReadLine());
		
			Console.WriteLine("dime el valor de c");
		c = Convert.ToInt32(System.Console.ReadLine());
		
		raiz=b*b - 4 * a*c;
		
		if (raiz<0)
		{
			Console.WriteLine("no es posible siendo un numero negativo");
			
		}
		else if (a==0)
		{
			Console.WriteLine("No es una ecuacion de segundo grado");
		}
		else
		{
		resultado=-b+ Math.Sqrt(raiz) /(2*a);
		Console.WriteLine("la solucion es {0}",resultado);
		resultado=-b- Math.Sqrt(raiz) /(2*a);
		Console.WriteLine("la solucion es {0}",resultado);
		}		
	}
}
