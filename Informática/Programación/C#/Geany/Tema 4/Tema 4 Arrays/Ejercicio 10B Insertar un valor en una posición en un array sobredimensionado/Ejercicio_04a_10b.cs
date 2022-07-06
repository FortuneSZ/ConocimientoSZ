/* Esta variante del ejercicio 10 le pedirá al usuario que introduzca un
título,el cual será colocado en la posición 3 */
 
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
		 
		 
		 if(cantidad < juegos.Length)
		 {
			 Console.WriteLine("Escribe un nuevo videojuego");
			 ultimoJuego = Console.ReadLine();
		 }
		 // Insertar nuevo dato en posicion 3 //
		 Console.WriteLine("Insertamos nuevo dato en la posicion 3");
		 int posicionInsertar = 3;
		 for(int i = cantidad; i > posicionInsertar-1; i--)
		 {
			 juegos[i] = juegos [i-1];
		 }
		 juegos[posicionInsertar-1] = ultimoJuego;
		 cantidad++;
		 
		Console.WriteLine("Listado de juegos");
		for(int i = 0; i < cantidad; i++)
		{
			Console.WriteLine(juegos[i]);
		}
			 
	 }
 }
		 

