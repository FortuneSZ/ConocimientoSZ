/*Este programa crea un array y almacena 5 nombres,luego le pide al usuario que
introduza nombres,y si coincide el nombre escrito por uno almacenado en el array
le dirá que está en el,de lo contrario le dirá que no está*/
using System;

class Ejercicio_04a_06
{
	static void Main()
	{
		string[] nombres = new string[5];
		string nombre;
		bool estar = false;
		Console.WriteLine("escriba cinco nombres");
		for (int i = 0; i < 5; i++)
		{
			nombres[i] = (Console.ReadLine());
		}
		Console.WriteLine("introduzca un nombre");
		do
		{
			estar = false;
			nombre = (Console.ReadLine());

			for (int i = 0; i < 5; i++)
			{
				if (nombres[i] == nombre)
				{
					estar = true;
				}
			}

			if (estar == true)
			{
				Console.WriteLine("ese nombre esta en el array");
			}
			if (estar != true && nombre != "fin")
			{
				Console.WriteLine("ese nombre no esta en el array");
			}
		}
		while (nombre != "fin");
	}
}
