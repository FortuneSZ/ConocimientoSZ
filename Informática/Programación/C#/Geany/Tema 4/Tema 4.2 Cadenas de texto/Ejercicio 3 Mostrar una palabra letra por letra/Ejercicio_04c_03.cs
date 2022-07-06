/*Este programa le pedirá al usuario que introduzca un no,mbre,y este lo
mostrará letra por letra,empleando un guión como separador*/
using System;
class Ejercicio_04c_03
{
	static void Main()
	{
		string nombre;
		Console.WriteLine("escriba su nombre");
		nombre = Console.ReadLine();
		for (int i=0;i<nombre.Length;i++)
		{
			
				Console.Write(nombre[i]);
			if (i<nombre.Length-1)
			{
				Console.Write("-");
			}
		}
		
	}
    
}	
