/* Programa que defina un struct que almacene datos */

using System;
class Ejercicio_04b_01
{
	struct musica
	{
		public string artista;
		public string titulo;
		public int segundos;
		public int tamKb;
	}
	
	static void Main()
	{
		musica musica1;
		
		Console.WriteLine("Dime el título de la cancion");
		musica1.titulo = Console.ReadLine();
		
		Console.WriteLine("Dime el artista de la cancion");
		musica1.artista = Console.ReadLine();
		
		Console.WriteLine("Dime cuando dura la cancion (en segundos)");
		musica1.segundos = Convert.ToInt32(Console.ReadLine());	
		
		Console.WriteLine("Dime cuantos Kb ocuapa la cancion");
		musica1.tamKb = Convert.ToInt32(Console.ReadLine());	
		
		Console.WriteLine("Esto es lo que has dicho");
		Console.WriteLine("Titulo:{0}",musica1.titulo);	
		Console.WriteLine("Artista:{0}",musica1.artista);	
		Console.WriteLine("Duración:{0}",musica1.segundos);	
		Console.WriteLine("Tamaño Kb:{0}",musica1.tamKb);	
	}
}
		
