/*este programa pide 2 variables y luego realiza dos operaciones,las cuales
muestra en la misma linea */
using System;
class ejercicio_01c_10
{

	static void Main()
	{
		int a, b;
		System.Console.WriteLine("escribe el primer numero");
		a = System.Convert.ToInt32(System.Console.ReadLine());

		System.Console.WriteLine("escribe el segundo numero");
		b = System.Convert.ToInt32(System.Console.ReadLine());
		int c = (a + b) * (a - b);
		int d = a * a - b * b;
		Console.Write("resultado 1 = a " + c);
		Console.Write(" resultado 2 = a " + d);

	}
}
