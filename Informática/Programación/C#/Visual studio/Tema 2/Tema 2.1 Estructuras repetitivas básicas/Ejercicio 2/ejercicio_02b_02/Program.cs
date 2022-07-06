/* este programa se encarga de contar del 1 al 10 */
using System;
class ejercicio_02b_02
{

	static void Main()
	{
		int contador = 0, num = 1;

		while (contador < 10)
		{
			Console.WriteLine("{0}", num);
			contador = contador + 1;
			num = num + 1;
		}


	}
}
