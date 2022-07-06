/*Este programa se basa en el segundo programa de este tema,solo que con el
añadido de que este contará los días restantes hasta fin de año y los
mostrará por pantalla*/
using System;

class Ejercicio_04a_05
{
	static void Main()
	{
		int[] dias = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
		int mes, numerodia, diasrestantes;

		Console.WriteLine("escriba el numero del mes");
		mes = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("escriba el dia");
		numerodia = Convert.ToInt32(Console.ReadLine());

		diasrestantes = dias[mes - 1] - numerodia;
		for (int i = mes; i < dias.Length; i++)
		{
			diasrestantes = diasrestantes + dias[i];
		}
		Console.WriteLine("quedan {0} dias para que acabe el año"
		, diasrestantes);

	}
}
