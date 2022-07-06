/*Este programa reemplaza toda vocal de la frase introducida por el usuario
por la vocal o*/
using System;
using System.Text;
class Ejercicio_04c_013
{	
	static void Main()
	{
		Console.WriteLine("introduzca una frase o palabra");
		StringBuilder cadena = new StringBuilder(Console.ReadLine());
		for (int i=0;i<cadena.Length;i++)
		{
			if (cadena[i] =='a' ||
				cadena[i] =='e' ||
				cadena[i] =='i' ||
				cadena[i] =='u' )
			{
				cadena[i] = 'o';
			}
			if (cadena[i] =='á' ||
				cadena[i] =='é' ||
				cadena[i] =='í' ||
				cadena[i] =='ú' )
			{
				cadena[i] = 'ó';
			}		
		}
		Console.WriteLine(cadena);
	
	}
}

