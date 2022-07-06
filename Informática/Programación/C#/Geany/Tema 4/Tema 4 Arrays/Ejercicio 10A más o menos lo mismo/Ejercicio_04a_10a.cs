/* Programa que reserva espacio para almacenar hasta 100 titulos (string),
 * deje ya unos pocos y pida al usuario un nuevo titulo al final. El programa
 * deberá mostrar despues el listado actual de videojuegos. */
 
 using System;
 class Ejercicio_04a_10a
 {
	 static void Main()
	 {
		 string [] juegos = new string [100];
		 int cantidad = 0;
		 string ultimoJuego;
		 juegos[0] = "Mario Kart 8";
		 juegos[1] = "TF2";
		 juegos[2] = "CSGO";
		 juegos[3] = "WoW";
		 
		 cantidad = 4;
		 
		 if(cantidad < juegos.Length)
		 {
			 Console.WriteLine("Escribe un nuevo videojuego");
			 ultimoJuego = Console.ReadLine();
			 juegos[cantidad] = ultimoJuego;
			 cantidad++;
		 }
		 Console.WriteLine("Listado de juegos");
		 for(int i=0; i < cantidad; i++)
		 {
			 Console.WriteLine(juegos[i]);
		 }
			 
	 }
 }
		 
