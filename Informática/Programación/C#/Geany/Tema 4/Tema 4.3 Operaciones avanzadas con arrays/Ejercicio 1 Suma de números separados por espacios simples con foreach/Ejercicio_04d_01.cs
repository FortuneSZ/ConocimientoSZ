/*Este programa le pide al usuario una frase que contenga números separados por
espacios simples,los cuales sumará empleando foreach*/
using System;
using System.Text;
class Ejercicio_04d_01
{	
	static void Main()
	{

		int suma=0;
		string numeros;
		Console.WriteLine("introduzca números separados por espacios");
		numeros = Console.ReadLine();
		string[] numero = numeros.Split(' ');
		
		foreach(string p in numero)
		{
			int numero2= Convert.ToInt32(p);
			suma+= numero2;
		}
		Console.WriteLine("la suma es {0}",suma);
		
		
	}
}

