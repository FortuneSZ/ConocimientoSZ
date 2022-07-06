/* 
 * Programa que calcula la distancia entre dos puntos (x1, y1) - (x2, y2)
 * introducidos por el usuario
 */ 
 
using System;

class Ejercicio_03b_08
{
	static void Main()
	{
		int x1, y1, x2, y2;
		float distancia;
		
		Console.WriteLine("Escribe las coordenadas de los puntos");
		Console.Write("x1 = ");
		x1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("y1 = ");
		y1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("x2 = ");
		x2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("y2 = ");
		y2 = Convert.ToInt32(Console.ReadLine());
		
		distancia = (float)Math.Sqrt(Math.Pow(x1 - x2, 2) + 
			Math.Pow(y1 - y2, 2)); 
		Console.WriteLine("Distancia: {0}", distancia.ToString("N2"));
	}
}
