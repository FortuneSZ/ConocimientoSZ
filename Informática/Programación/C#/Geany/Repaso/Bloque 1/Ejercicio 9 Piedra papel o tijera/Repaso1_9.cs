/*
 * Programa que simula el juego de piedra, papel y tijera
 * Representamos la piedra con una R, papel con P y tijera con T
 */
using System;

class Repaso1_9
{
	static void Main()
	{
		string jugador1, jugador2;
		int victorias1 = 0, victorias2 = 0, empates = 0;
		
		Console.WriteLine("Escribe las jugadas. FIN para terminar");
		do
		{
			jugador1 = Console.ReadLine();
			if (jugador1 != "FIN")
			{
				jugador2 = Console.ReadLine();
				
				if (jugador1 == jugador2)
				{
					empates++;
				}
				else if ((jugador1 == "R" && jugador2 == "T") ||
				         (jugador1 == "P" && jugador2 == "R") ||
				         (jugador1 == "T" && jugador2 == "P"))
				{
					victorias1++;
				}
				else
				{
					victorias2++;
				}
			}
		}
		while(jugador1 != "FIN");
		
		Console.WriteLine("Victorias jug. 1: {0}", victorias1);
		Console.WriteLine("Victorias jug. 2: {0}", victorias2);
		Console.WriteLine("Empates: {0}", empates);
	}
} 
