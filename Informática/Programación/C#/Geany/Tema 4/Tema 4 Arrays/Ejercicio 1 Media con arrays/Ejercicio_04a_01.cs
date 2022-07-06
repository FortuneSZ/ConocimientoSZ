/*Este programa crea un array en el que almacenaremos 4 números,para
posteriormente calcular su media y mostrarla por pantalla*/
using System;

class Ejercicio_04a_01
{
	static void Main()
	{
	
		float [] numero = new float [4];
		float media=0;
		Console.WriteLine("Escriba 4 numeros");
		for (int i=0;i<4;i++)
		{
		numero[i] = Convert.ToSingle(Console.ReadLine());
		media = media + numero[i];
		}
		media= media/4;
		Console.WriteLine("la media es {0}",media);
	}
}
		
