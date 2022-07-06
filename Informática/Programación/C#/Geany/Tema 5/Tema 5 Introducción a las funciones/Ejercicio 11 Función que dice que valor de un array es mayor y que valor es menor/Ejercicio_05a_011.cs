/*este programa crea una función que en base a los valores de un array 
introducido por el usuario,y dice cual valor es el mayor y cual es el
menor*/
using System;


class Ejercicio_05a_011
{
    static void MaxMinArray(int[] numeros)
    {
		double maximo=0;
        double minimo=0;
		int posicionmax=0;
        int posicionmin=0;
		for(int i=0;i<numeros.Length;i++)
		{
			if (maximo==0)
			{
				maximo=numeros[i];
				posicionmax=i+1;
			}
			if (numeros[i]>maximo)
			{
				maximo=numeros[i];
				posicionmax=i;
			}
            if (minimo==0)
			{
				minimo=numeros[i];
				posicionmin=i+1;
			}
			if (numeros[i]<minimo)
			{
				minimo=numeros[i];
				posicionmin=i;
			}
		}
        Console.Clear();
		Console.WriteLine("el maximo es {0} y su posición es {1}"
		,maximo,posicionmax+1);
        Console.WriteLine("el minimo es {0} y su posición es {1}"
		,minimo,posicionmin+1);

    }
    
    static void Main()
	{
      int [] numeros = new int [5];
       Console.WriteLine("escriba los valores del array");
      for (int i=0;i<numeros.Length;i++)
      {
          numeros[i]=Convert.ToInt32(Console.ReadLine());
      }
      MaxMinArray(numeros);
      
    }
   
}
