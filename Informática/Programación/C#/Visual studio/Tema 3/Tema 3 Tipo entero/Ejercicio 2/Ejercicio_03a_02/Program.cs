/*Este programa se encarga de mostrar los valores que toman las variables
después de estas operaciones*/
using System;

class Ejercicio_03a_02
{
	static void Main()
	{
		int a, b, c;
		a = b = c = 5;
		b = a + 2;
		b -= 3;
		c = -3;
		c *= 2;
		++c;
		a *= b;

		Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
	}
}
