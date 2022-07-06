/*Este programa pide al usuario que introduzca un nombre,y lo muestra
como un triangulo decreciente*/
using System;
class Ejercicio_04c_05b
{	
	static void Main()
	{
		string nombre;
		Console.WriteLine("escriba su nombre");
		nombre = Console.ReadLine();
		Console.Clear();
		for(int i=0;i<nombre.Length;i++)
		{
			Console.WriteLine(nombre.Substring(0,nombre.Length-i));
		}
	}
}
