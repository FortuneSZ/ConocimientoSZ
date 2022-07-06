/* este programa consiste en introducir 2 numeros y decir cual es mayor*/
using System;
class ejercicio_02a_02
{
	static void Main()
	{
		int numero1,numero2;
		
		Console.WriteLine("Escribe el primer numero");
		numero1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Escribe el segundo numero");
		numero2 = Convert.ToInt32(Console.ReadLine());
		
		if (numero1>numero2)
		{
			Console.WriteLine("el primer numero es mayor");
		}
		
		if (numero2>numero1)
		{
			Console.WriteLine("el segundo numero es mayor");
		}
	}			
}
