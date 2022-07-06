/*este programa calculará el área de un círculo dado su radio*/
using System;
class ejercicio_03b_02
{	
	static void Main()
	{
		float area;
		int radio;
		
		Console.WriteLine("escriba el radio del circulo");
		radio = Convert.ToInt32(System.Console.ReadLine());
		area= 3.141516f*(radio*radio);
		Console.WriteLine("el area del circulo es {0}",area);
	}
}
