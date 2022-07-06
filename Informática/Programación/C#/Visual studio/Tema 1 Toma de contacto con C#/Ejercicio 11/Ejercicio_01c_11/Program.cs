/*en este programa crearemos una tabla de multiplicar en base a
2 valores que pediremos al usuario*/

using System;
class ejercicio_01c_11
{

	static void Main()
	{
		int a, b;
		Console.WriteLine("escribe un primer numero");
		a = Convert.ToInt32(System.Console.ReadLine());

		Console.WriteLine("escribe el numero de veces");
		b = Convert.ToInt32(System.Console.ReadLine());

		while (b > 0)
		{
			Console.WriteLine(a * b);
			b = b - 1;
		}
	}

}
