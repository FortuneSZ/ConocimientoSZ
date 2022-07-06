/*Ente programa le pedirá al usuario que introduzca 10 nombres y los guardará
en un array,luego le pedirá al usuario que introduzca nombres,y si está en el
array dirá que está en el y en que posición,de lo contrario dirá que no está*/
using System;

class Ejercicio_04a_08
{
	static void Main()
	{
		string [] nombres = new string [10];
		string nombre;
		bool estar=false;
		int [] posicion = new int [10];
		Console.WriteLine("escriba diez nombres");
		for(int i=0;i<10;i++)
		{
			nombres[i] =(Console.ReadLine());
		}
			Console.WriteLine("introduzca un nombre");
		do
		{
			estar=false;
			nombre=(Console.ReadLine());
		
			for(int i=0;i<10;i++)
			{
				if( nombres[i]==nombre)
				{
					estar=true;
					posicion[i]=i;
				}
			}
			
				if(estar==true)
				{
					Console.WriteLine("ese nombre esta en el array");
					Console.Write("esta en la posicion ");
					for(int i=0;i<10;i++)
					{
						if(nombres[i]==nombre)
						{
							Console.Write(posicion[i]);
							if (i!=9)
							{
								Console.Write(",");
							}
						}
					}
				}
				if(estar!=true && nombre!="fin")
				{
					Console.WriteLine("ese nombre no esta en el array");
				}
		}
		while(nombre!="fin");
	}
}
		
