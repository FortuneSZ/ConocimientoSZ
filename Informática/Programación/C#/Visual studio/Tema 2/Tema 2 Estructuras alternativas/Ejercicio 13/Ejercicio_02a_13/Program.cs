﻿/*este programa consiste en introducir un numero,si es del 1 al 12 mostrara
el mes correspondiente a ese numero,si es cualquier otro numero dira que
es un mes incorrecto*/
using System;
class ejercicio_02a_13
{

	static void Main()
	{
		int mes;

		Console.WriteLine("dime un mes");
		mes = Convert.ToInt32(Console.ReadLine());
		switch (mes)
		{
			case 1:
				Console.WriteLine("Enero");
				break;
			case 2:
				Console.WriteLine("Febrero");
				break;
			case 3:
				Console.WriteLine("Marzo");
				break;
			case 4:
				Console.WriteLine("Abril");
				break;
			case 5:
				Console.WriteLine("Mayo");
				break;
			case 6:
				Console.WriteLine("Junio");
				break;
			case 7:
				Console.WriteLine("Julio");
				break;
			case 8:
				Console.WriteLine("Agosto");
				break;
			case 9:
				Console.WriteLine("Septiembre");
				break;
			case 10:
				Console.WriteLine("Octubre");
				break;
			case 11:
				Console.WriteLine("Noviembre");
				break;
			case 12:
				Console.WriteLine("diciembre");
				break;
			default:
				Console.WriteLine("mes incorrecto");
				break;
		}

	}
}
