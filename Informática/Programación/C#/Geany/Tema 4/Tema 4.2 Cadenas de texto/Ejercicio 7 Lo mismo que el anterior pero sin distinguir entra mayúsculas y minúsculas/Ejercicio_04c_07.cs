/*Este programa le pedirá al usuario que rellene un array de nombres del tamaño
10,posteriormente le pedirá al usuario que escriba una palabra o letra,y si esta
se encuentra en alguna palabra del array,independientemente si está en mayúscula
o minúscula, le dirá en cuales y su posición,esto se repetirá hasta que el 
usuario escriba fin*/
using System;
class Ejercicio_04c_07
{	
	static void Main()
	{
		int contador=1;
		string palabraabuscar="";
		string[] palabras = new string [10];
			for (int i=0;i<palabras.Length;i++)
			{
				Console.WriteLine("escriba la {0} palabras",contador);	
				palabras[i] = Console.ReadLine();
				contador++;
			}
			Console.Clear();
			do
			{
				Console.WriteLine("Escribe el texto a buscar:");
				palabraabuscar = Console.ReadLine();
				if (palabraabuscar != "fin")
				{
					for (int i = 0; i < palabras.Length; i++)
					{
						if (palabras[i].ToUpper().Contains(palabraabuscar
						.ToUpper()))
						{
							Console.WriteLine("Encontrado en posicion {0}",i+1);
						}
					}
				}
			}
			while (palabraabuscar != "fin");
	}
}
