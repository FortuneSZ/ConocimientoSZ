/*Este programa le pedirá al usuario 10 números y le dirá cual es el menor*/
using System;

class Ejercicio_04a_09
{
	static void Main()
	{
		double [] numero = new double [10];
		double minimo=0;
		int posicion=0;
		Console.WriteLine("escriba 10 numeros");
		for(int i=0;i<10;i++)
		{
			numero[i]= Convert.ToDouble(Console.ReadLine());
			if (minimo==0)
			{
				minimo=numero[i];
				posicion=i+1;
			}
			if (numero[i]<minimo)
			{
				minimo=numero[i];
				posicion=i;
			}
		}
		Console.WriteLine("el minimo es {0} y su posiciín es {1}"
		,minimo,posicion+1);	
	}
}
		
