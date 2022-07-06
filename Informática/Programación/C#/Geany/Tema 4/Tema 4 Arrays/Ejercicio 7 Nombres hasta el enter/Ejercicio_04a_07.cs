/*Este programa le pedirá nombres al usuario hasta que presione enter,una vez
lo haga,mostrará por pantalla el número de nombres introducidos y los nombres
introducidos*/
using System;

class Ejercicio_04a_07
{
	static void Main()
	{
		string [] nombres = new string [100];
		string nuevonombre;
		int numeronombre=0;
		
		Console.WriteLine("escriba nombres");
		do
		{
			nuevonombre=Console.ReadLine();
			if (nuevonombre != "")
			{
				nombres[numeronombre]=nuevonombre;
				numeronombre++;
			}
		}
		while(nuevonombre != "");
		Console.WriteLine("has escrito {0} nombres",numeronombre);
		for(int i=0;i<=numeronombre;i++)
		{
			Console.WriteLine(nombres[i]);
		}
	}
}
		
