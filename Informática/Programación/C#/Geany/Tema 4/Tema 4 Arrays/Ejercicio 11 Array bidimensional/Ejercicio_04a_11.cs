/* Programa que diga que tamaño de cada una de las filas tiene y luego las
rellene,y posteriormente diga cual es el mayor número de cada fila */
 
 using System;
 class Ejercicio_04a_11
{
	 static void Main()
	{	
		//recorremos el array pidiendo al usuario que lo rellene
		int[,] datos = new int[2,10];
		int max;
		
			for(int i = 0; i < datos.GetLength(0); i++)
			{
				for (int j = 0; j < datos.GetLength(1); j++)
				{
					Console.Write("Casilla {0},{1}:",i+1,j+1);
					datos[i,j]=Convert.ToInt32(Console.ReadLine());
				}
			}
			//Recorremos el array de vuelta para comparar y sacar los maximos
			for(int i = 0; i < datos.GetLength(0); i++)
			{
				max=datos[i,0];
				for (int j = 1; j < datos.GetLength(1); j++)
				{
					if(datos[i,j]>max)
					{
						max=datos[i,j];
					}
				}
				Console.WriteLine("El mayor de la fila {0} es: {1}",i+1,max);
				max=0;
			}
			/*comprobar que los datos se introducen
			for(int i = 0; i < datos.GetLength(0); i++)
			{
				Console.WriteLine("Rellena la fila {0}",i);
				for (int j = 0; j < datos.GetLength(1); j++)
				{
					Console.Write(datos[i,j]+" ");
					datos[i, j]=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine();
				}
			}*/
	}
}
