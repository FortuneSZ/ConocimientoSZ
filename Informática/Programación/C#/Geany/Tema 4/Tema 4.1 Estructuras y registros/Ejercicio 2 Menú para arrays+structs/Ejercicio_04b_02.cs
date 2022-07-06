/*Este programa crea un struct para almacenar datos,y un array de canciones
que emplea el struct,array al que accederemos por medio de un menú*/
using System;


class Ejercicio_04b_02
{
	enum menu{AÑADIR=1, MOSTRAR, BUSCAR, SALIR }
	
	struct canciones
	{
		public string artista;
		public string titulo;
		public int duracion;
		public int tamKb;
	}
	static void Main(string[] args)
	{
		int opcion, cont = 0;
		string artistabuscar;
		bool hayartista = false;

		canciones[] cancion = new canciones[100];


		do
		{
		Console.WriteLine(":::::::::::::::::::.");
		Console.WriteLine("Menu de opciones:");
		Console.WriteLine((int)menu.AÑADIR +
		". Añadir una cancion al final");
		Console.WriteLine((int)menu.MOSTRAR +
		". Mostrar los titulos de todas las canciones");
		Console.WriteLine((int)menu.BUSCAR +
		". Buscar canciones de un artista determinado");
		Console.WriteLine((int)menu.SALIR +
		". Salir del programa");
		Console.Write("Que desea hacer?: ");
		opcion = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(":::::::::::::::::::.");
	
		switch (opcion)
		{
		case 1:
		Console.WriteLine(":::::::::::::::::::");
		Console.WriteLine("Has elegido añadir una cancion al final");
		Console.Write("Dime el nombre del artista: ");
		cancion[cont].artista = Console.ReadLine();
		Console.Write("Dime el nombre del titulo: ");
		cancion[cont].titulo = Console.ReadLine();
		Console.Write("Dime la duracion en minutos: ");
		cancion[cont].duracion = Convert.ToInt32(Console.ReadLine());
		Console.Write("Dime el tamanyo de la cancion: ");
		cancion[cont].tamKb = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(":::::::::::::::::::");

		cont++;
		break;

		case 2:
		Console.WriteLine(":::::::::::::::::::");
		if (cont > 0)
		{
			Console.WriteLine("Has elegido mostrar"+
			 "los titulos de todas las canciones");
			Console.WriteLine("Los titulos son: ");
			for (int i = 0; i < cont; i++)
			{

			Console.WriteLine("{0}. {1}", i + 1, cancion[i].titulo);
			Console.WriteLine("Artista: {0}"
			,cancion[i].artista);
			Console.WriteLine("Duración: {0}"
			,cancion[i].duracion);
			}
		}
		else Console.WriteLine("No hay canciones introducidas");
                       
		Console.WriteLine(":::::::::::::::::::");
		break;
		case 3:
                       
		Console.WriteLine(":::::::::::::::::::");
		Console.WriteLine("Has elegido buscar canciones por artista");
		Console.Write("Que artista quieres buscar?: ");
		artistabuscar = Console.ReadLine();
                        
		for (int i=0; i< cont; i++)
		{
			if (artistabuscar == cancion[i].artista)
			{
                                
				Console.WriteLine("Su cancion {0} es {1}"
				, i+1, cancion[i].titulo);
				hayartista=true;
			}
                            
		}
		if (!hayartista)
		{
			Console.WriteLine("No se han encontrado"+
			 "canciones para ese artista");
		}
		Console.WriteLine(":::::::::::::::::::");
		break;
		case 4:
		Console.WriteLine(":::::::::::::::::::");
		Console.WriteLine("Has elegido salir");
		Console.WriteLine(":::::::::::::::::::");
		Console.WriteLine(":::::::::::::::::::");
		break;
		}

		} while (opcion != 4);
	}
    
}	
