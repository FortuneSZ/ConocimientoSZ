/*el usuario introduce una letra y el programa le dice si es una vocal
o una consonante*/
using System;
class ejercicio_02a_12
{

	static void Main()
	{
		char letra;

		Console.WriteLine("dime una letra");
		letra = Convert.ToChar(Console.ReadLine());
		switch (letra)
		{
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':
				Console.WriteLine("es una vocal");
				break;
			default:
				Console.WriteLine("Es una consonante");
				break;
		}

	}
}
