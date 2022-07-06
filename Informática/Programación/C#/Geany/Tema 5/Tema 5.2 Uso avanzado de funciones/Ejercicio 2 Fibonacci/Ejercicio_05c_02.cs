/* Programa Fibonacci que devuelva el enesimo elemento de la secuencia */

using System;
class Ejercicio_05c_02
{
	static int Fibonacci(int posicion)
	{
		if(posicion == 0 || posicion == 1)
			return posicion;

		return Fibonacci(posicion - 1) + Fibonacci(posicion - 2);
	}

	public static void Main()
	{
		int numero = 0;
		Console.WriteLine(Fibonacci(numero));

		numero = 5;
		Console.WriteLine(Fibonacci(numero));

		numero = 10;
		Console.WriteLine(Fibonacci(numero));
	}
}
