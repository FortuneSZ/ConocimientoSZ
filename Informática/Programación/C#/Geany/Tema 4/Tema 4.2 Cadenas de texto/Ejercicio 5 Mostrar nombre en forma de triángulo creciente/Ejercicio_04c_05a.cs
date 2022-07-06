/*Este programa pide al usuario que introduzca un nombre,y lo muestra
como un triangulo creciente*/
using System;
class Ejercicio_04c_05a
{	
	static void Main()
	{
		string nombre;
		Console.WriteLine("escriba su nombre");
		nombre = Console.ReadLine();
        Console.Clear();
		for(int i=1;i<=nombre.Length;i++)
		{
			Console.WriteLine(nombre.Substring(0,i));
		}
	}
}
