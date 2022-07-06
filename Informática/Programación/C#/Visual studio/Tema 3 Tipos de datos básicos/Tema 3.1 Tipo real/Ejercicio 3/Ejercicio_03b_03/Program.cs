/*este programa calcula la velocidad en m/s en base de los kilómetros
,las horas,minutos y segundos introducidos por el usuario*/
using System;
class ejercicio_03b_03
{
	static void Main()
	{
		int km, m, horas, minutos, segundos;
		float velocidad;
		Console.WriteLine("escriba el numero de km");
		km = Convert.ToInt32(System.Console.ReadLine());

		Console.WriteLine("escriba el numero de horas");
		horas = Convert.ToInt32(System.Console.ReadLine());

		Console.WriteLine("escriba el numero de minutos");
		minutos = Convert.ToInt32(System.Console.ReadLine());

		Console.WriteLine("escriba el numero de segundos");
		segundos = Convert.ToInt32(System.Console.ReadLine());

		m = km * 1000;
		segundos = (horas * 3600) + (minutos * 60) + segundos;
		velocidad = m / segundos;
		Console.WriteLine("la velocidad fue {0} ", velocidad);
	}
}
