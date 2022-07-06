/* 
 * Programa que dibuja el contorno de un cuadrado usando Sleep tras
 * cada asterisco
 */ 
 
using System;
using System.Threading;

class Ejercicio_05b_05
{	
    static void Main()
    {
		const int LADO = 5;
		int x = 0, y = 0;
		
		Console.ForegroundColor = ConsoleColor.Green;
		
		for(int i = 0; i < (LADO - 1) * 4; i++)
		{
			if (i < LADO - 1)
			{
				x++;
			}
			else if (i < (LADO - 1) * 2)
			{
				y++;
			}
			else if (i < (LADO - 1) * 3)
			{
				x--;
			}
			else
			{
				y--;
			}
			
			Console.SetCursorPosition(x, y);
			Console.Write("*");
			Thread.Sleep(500);
		}
		
		Console.SetCursorPosition(0, LADO + 1);
    }
}
