/*Este programa pedirá al usuario que introduzca una matriz y le dirá si es
una matriz identidad o no*/
using System;

class Practica_4_1_2
{
	static void Main()
	{
		int tamFila,filas;
		/*introducimos el tamaño de la matriz*/
		Console.WriteLine("diga el numero de filas de la matriz");
		filas = Convert.ToInt32(Console.ReadLine());
		int [][] matriz = new int [filas][];
		int [] contador = new int [filas];
		int contadorfilas=0,contadorcolumnas=0;
		bool identidad=true;
		
		/*introducimos los valores */
		for(int i = 0; i < matriz.Length; i++)
		{
			Console.WriteLine("Indica el tamaño de la fila {0}", i+1);
			tamFila = Convert.ToInt32(Console.ReadLine());
			matriz[i] = new int[tamFila];
			contador[i]=0;
			contadorcolumnas++;
				
			for (int j = 0; j < matriz[i].Length; j++)
			{
				Console.Write("Casilla {0},{1}:",i+1,j+1);
				matriz[i][j]=Convert.ToInt32(Console.ReadLine());
				contadorfilas++;
				
				if (contador[i] == 0)
				{
					contador[i] = matriz[i][j];
				}
				else
				{
					contador[i] = contador[i] + matriz[i][j];
				}
			}
		}
		contadorfilas=contadorfilas/contadorcolumnas;
		Console.Clear();
		
		/*mostramos la matriz por pantalla*/
		for (int i=0;i<matriz.Length;i++)
		{
			for (int j=0;j< matriz[i].Length;j++)
			{
				Console.Write(matriz[i][j]+" ");
			}
			Console.WriteLine("");
		}
		Console.WriteLine("");
		
		/*hacemos todas las verificaciones*/
		for (int i=0;i<contador.Length;i++)
		{

			if (contador[i] !=1 || contadorfilas != contadorcolumnas)
			{
				identidad=false;
			}
		}
		for (int i=0;i<matriz.Length;i++)
		{
			for (int j=0;j< matriz.Length;j++)
			{
				if (i==j && matriz[i][j]!=1)
				{
					identidad=false;
				}
			}
		}
		/*mostramos el resultado */
		Console.WriteLine("la matriz tiene {0} filas y {1} columnas"
		,contadorfilas,contadorcolumnas);
		Console.WriteLine("");
		if (identidad==false)
		{
			Console.WriteLine("no es una matriz identidad");
		}
		else
		{
			Console.WriteLine("es una matriz identidad");
		}			
	}
					
}
