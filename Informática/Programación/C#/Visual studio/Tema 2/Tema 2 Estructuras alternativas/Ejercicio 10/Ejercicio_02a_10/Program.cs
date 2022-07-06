/* vamos a crear un programa que nos diga si un número,ambos o ninguno
es positivo*/
using System;
class ejercicio_02a_010
{

	static void Main()
	{
		int numero1, numero2;

		Console.WriteLine("dime 2 numeros");
		numero1 = Convert.ToInt32(System.Console.ReadLine());
		numero2 = Convert.ToInt32(System.Console.ReadLine());


		if (numero1 >= 0 && numero2 >= 0)
		{
			Console.WriteLine("Los dos numeros son positivos");
		}
		else if (numero1 >= 0 && numero2 < 0)
		{
			Console.WriteLine("El primer numero es positivo" +
			" pero es segundo no", numero2);
		}
		else if (numero2 >= 0 && numero1 < 0)
		{
			Console.WriteLine("El segundo numero es positivo" +
				" pero es primero no", numero2);
		}
		else if (numero1 < 0 && numero2 < 0)
		{
			Console.WriteLine("ninguno de los numeros es positivo");
		}
	}
}
