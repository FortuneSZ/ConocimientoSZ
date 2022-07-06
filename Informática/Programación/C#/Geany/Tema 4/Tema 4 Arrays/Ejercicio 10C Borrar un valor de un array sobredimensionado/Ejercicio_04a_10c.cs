/* Este programa continuará con loa nteriormente realizado en los apartados
anteriores,en este añadiremos la opción de borrar un título del array */
 
 using System;
 class Ejercicio_04a_10a
 {
	 static void Main()
	 {
		 string [] juegos = new string [100];
		 int cantidad = 0;
		 string ultimoJuego = "";
		 juegos[0] = "Mario Kart 8";
		 juegos[1] = "TF2";
		 juegos[2] = "CSGO";
		 juegos[3] = "WoW";
		 
		 cantidad = 4;
		 
		 // Añadir juego al final //
		 if(cantidad < juegos.Length)
		 {
			 Console.WriteLine("Escribe un nuevo videojuego");
			 ultimoJuego = Console.ReadLine();
			 juegos[cantidad] = ultimoJuego;
			 cantidad++;
		 }
		 // Insertar nuevo dato en posicion 3 //
		 Console.WriteLine("Insertamos nuevo dato en la posicion 3");
		 int posicion = 3;
		 if(cantidad < juegos.Length)
		 {
			 for(int i = cantidad; i >= posicion; i--)
			 {
				 juegos[i] = juegos [i-1];
			 }
			 juegos[posicion-1] = "New World";
			 cantidad++;
		 }
		 
		 Console.WriteLine("Listado de juegos");
		 for(int i = 0; i < cantidad; i++)
		 {
			 Console.WriteLine(juegos[i]);
		 }
		 // Pedimos una celda que elimine esa celda //
		Console.WriteLine("Que posicion quieres borrar:");
		posicion=Convert.ToInt32(Console.ReadLine());
		posicion--;
		if(posicion>=0 &&posicion<cantidad)
		{
			for (int i = posicion; i < cantidad - 1; i++)
			{
				juegos[i] = juegos[i+1];
			}
			cantidad--;
		}
		else
		{
			Console.WriteLine("Posicion erronea o vacia.");
		}
		Console.WriteLine("Listado de juegos");
		for(int i=0;i<cantidad;i++)
		{
			Console.WriteLine(juegos[i]);
		}
	 }
 }
		 
