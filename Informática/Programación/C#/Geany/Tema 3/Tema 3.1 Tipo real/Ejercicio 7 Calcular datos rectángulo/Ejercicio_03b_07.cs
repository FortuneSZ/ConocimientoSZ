/* 
 * Programa que calcula el perímetro, área y longitud diagonal de
 * un rectángulo pidiéndole al usuario la base y la altura
 */ 
 
using System;

class Ejercicio_03b_07
{
	static void Main()
	{
		int baseRect, alturaRect;
		float perimetro, area, diagonal;
		
		Console.WriteLine("Introduce la base del rectángulo:");
		baseRect = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce la altura del rectángulo:");
		alturaRect = Convert.ToInt32(Console.ReadLine());
		
		perimetro = 2 * baseRect + 2 * alturaRect;
		area = baseRect * alturaRect;
		diagonal = (float)Math.Sqrt(baseRect*baseRect + alturaRect*alturaRect);
		
		Console.WriteLine("Perímetro: {0}", perimetro.ToString("N1"));
		Console.WriteLine("Área: {0}", area.ToString("N1"));
		Console.WriteLine("Diagonal: {0}", diagonal.ToString("N1"));
		
		
	}
}
