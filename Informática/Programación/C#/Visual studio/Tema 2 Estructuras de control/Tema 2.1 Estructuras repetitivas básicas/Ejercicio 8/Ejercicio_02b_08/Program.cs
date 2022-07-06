/*en este programa crearemos una tabla de multiplicar en base a
2 valores que pediremos al usuario*/

using System;
class ejercicio_02b_08
{

	static void Main()
	{
		int num;
		Console.WriteLine("introduzca un numero");
		num = Convert.ToInt32(System.Console.ReadLine());

		for (int cont = 1; cont <= 10; cont++)
		{
			Console.WriteLine(num * cont);
		}
	}
}
