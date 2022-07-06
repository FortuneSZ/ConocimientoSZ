/*Este programa le pedirá al usuario que defina la longitud del array de
números,para posteriormente pedirle que introduzca dicha cantidad de números,
calcular su media y mostrar cuales de esos números están por encima de dicha
media*/
using System;

class Ejercicio_04a_04
{
	static void Main()
	{
		float media=0;
		float [] numero;
		
		Console.WriteLine("Escriba la cantidad de numeros");
		int med = Convert.ToInt32(Console.ReadLine());
		numero = new float [med];
		Console.WriteLine("Escriba los numeros");
		for (int i=0;i<med;i++)
		{
			numero[i] = Convert.ToSingle(Console.ReadLine());
			media += numero[i];
		}
		media= media/med;
		
		Console.WriteLine("la media es {0}",media);
		for (int i = 0;i<=med-1;i++)
		{
			
			if (numero[i]>media)
			{
				Console.Write(numero[i] +" ");
			}
		}
	}
}
		
