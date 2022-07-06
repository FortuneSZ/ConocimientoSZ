/*Este programa va pidiendo numeros al usuario y los va sumando,pero para si el
numero introducido es 0 o negativo */
using System;
class ejercicio_02b_04
{

	static void Main()
	{
		int numero, numero2 = 0;

		Console.WriteLine("dime un numero");


		do
		{
			numero = Convert.ToInt32(System.Console.ReadLine());
			if (numero > 0)
			{
				numero2 = numero2 + numero;
				Console.WriteLine("el numero es " + numero2);
			}
		}

		while (numero > 0);


	}
}
