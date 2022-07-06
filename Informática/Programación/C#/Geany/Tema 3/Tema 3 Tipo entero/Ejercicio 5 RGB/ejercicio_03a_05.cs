/*Este programa convertirá el código numérico rgb que introduzcas a su variante
hexadecimal */
using System;
class ejercicio_03a_05
{
	
	static void Main()
	{	
		byte color1,color2,color3;
		
		Console.WriteLine("escriba el valor RGB del color");
		color1 = Convert.ToByte(System.Console.ReadLine());
		color2 = Convert.ToByte(System.Console.ReadLine());
		color3 = Convert.ToByte(System.Console.ReadLine());
		
		string rojo=Convert.ToString(color1, 16);
		string verde=Convert.ToString(color2, 16);
		string azul=Convert.ToString(color3, 16);
		
		Console.WriteLine("el codigo del color es {0}{1}{2}",rojo,verde,azul);
	}
}
