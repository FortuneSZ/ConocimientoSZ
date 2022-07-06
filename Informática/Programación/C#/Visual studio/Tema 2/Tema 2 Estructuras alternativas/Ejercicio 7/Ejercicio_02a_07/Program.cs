/* vamos a crear un programa que nos diga si el número introducido es
multiplo de 2 pero no de 3*/
using System;
class ejercicio_02a_07
{

	static void Main()
	{
		int numero;

		Console.WriteLine("dime el primer numero");
		numero = Convert.ToInt32(System.Console.ReadLine());

		if (numero % 2 == 0 && numero % 3 != 0)
		{
			Console.WriteLine(" el numero es multiplo de 2 y no de 3");
		}

		else
		{
			Console.WriteLine("el numero no cumple la condicion");
		}
	}

}
