/*
 * Programa de cruce de trenes
 * - Z es la distancia entre ciudades A y B (>= 300km)
 * - X es la velocidad del tren de A a B (0 <= X <= 250km/h)
 * - Y es la velocidad del tren de B a A (0 <= Y <= 250km/h)
 */
using System;

class Repaso1_11
{
	static void Main()
	{
		int x = 0, y = 0, z = 0;
		bool incorrecto;
		float tiempo, distancia;
		
		incorrecto = true;
		do
		{
			try
			{
				Console.WriteLine("Escribe la distancia Z:");
				z = Convert.ToInt32(Console.ReadLine());
				if (z >= 300)
				{
					incorrecto = false;
				}
			} 
			catch (Exception)
			{
				Console.WriteLine("Formato de número incorrecto");
			}
		}
		while (incorrecto);
		
		incorrecto = true;
		do
		{
			try
			{
				Console.WriteLine("Escribe la velocidad X:");
				x = Convert.ToInt32(Console.ReadLine());
				if (x >= 0 && x <= 250)
				{
					incorrecto = false;
				}
			} 
			catch (Exception)
			{
				Console.WriteLine("Formato de número incorrecto");
			}
		}
		while (incorrecto);

		incorrecto = true;
		do
		{
			try
			{
				Console.WriteLine("Escribe la velocidad Y:");
				y = Convert.ToInt32(Console.ReadLine());
				if (y >= 0 && y <= 250)
				{
					incorrecto = false;
				}
			} 
			catch (Exception)
			{
				Console.WriteLine("Formato de número incorrecto");
			}
		}
		while (incorrecto);
		
		Console.WriteLine("Z = {0}km, X = {1}km/h, Y = {2}km/h", z, x, y);
		
		tiempo = (float)z / (x + y);
		distancia = x * tiempo;
		
		Console.WriteLine("Solución: se cruzan a {0}Km de A", 
			distancia.ToString("N2"));
		
	}
} 
