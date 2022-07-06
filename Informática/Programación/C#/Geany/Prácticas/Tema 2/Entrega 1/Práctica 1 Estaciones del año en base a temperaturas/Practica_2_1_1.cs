/*este programa pide al usuario 3 temperaturas es grados centrigrados,y
dependiendo de ellas dirá si es verano,invierno,primavera u otoño */
using System;
class Practica_2_1_1
{
	
	static void Main()
	{	
		int grado1,grado2,grado3;
		
		Console.WriteLine("introduzca una temperatura en grados celsius");
		grado1 = Convert.ToInt32(System.Console.ReadLine());
		
		Console.WriteLine("introduzca otra temperatura en grados celsius");
		grado2 = Convert.ToInt32(System.Console.ReadLine());
		
		Console.WriteLine("introduzca otra temperatura en grados celsius");
		grado3 = Convert.ToInt32(System.Console.ReadLine());
	
		if (grado1>25 && grado2>25 && grado3>25)
		{
			Console.WriteLine("Es verano");
		}
			else if (grado1<15 || grado2<15 || grado3<15)
			{
				Console.WriteLine("Es invierno");
			}
			else 
			{
				Console.WriteLine("Es primavera u otoño");	
			}	
	}	
}
