/*Este programa le pedirá al usuario que escriba 6 números y luego los
mostrará por pantalla en orden inverso al escrito*/
using System;

class Ejercicio_04a_03
{
	static void Main()
	{

		int[] numero = new int[6];
		Console.WriteLine("Escriba 6 numeros");
		for (int i = 0; i < 6; i++)
		{
			numero[i] = Convert.ToInt32(Console.ReadLine());
		}
		for (int i = 5; i >= 0; i--)
		{
			if (i == 0)
			{
				Console.Write(numero[i]);
			}
			else
			{
				Console.Write(numero[i] + ", ");
			}
		}
	}
}
