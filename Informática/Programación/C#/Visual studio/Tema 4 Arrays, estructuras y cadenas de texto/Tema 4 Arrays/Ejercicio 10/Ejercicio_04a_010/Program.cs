/*Este programa creará un array sobredimensionado,con varios títulos ya
almacenados y el usuario añadirá uno nuevo que se colocará al final de estos*/
using System;

class Ejercicio_04a_010
{
	static void Main()
	{
		string[] juego = new string[100];
		string nuevojuego;
		int cantidad = 0;
		juego[0] = "Mortal cumbia";
		juego[1] = "Pokecamion";
		juego[2] = "Ella no te ama el juego";
		juego[3] = "Just natsuki";
		cantidad = 4;

		if (cantidad < juego.Length)
		{
			Console.WriteLine("Escribe un nuevo videojuego");
			nuevojuego = Console.ReadLine();
			juego[cantidad] = nuevojuego;
			cantidad++;
		}
		Console.WriteLine("Listado de juegos");
		for (int i = 0; i < cantidad; i++)
		{
			Console.WriteLine(juego[i]);
		}
	}
}
