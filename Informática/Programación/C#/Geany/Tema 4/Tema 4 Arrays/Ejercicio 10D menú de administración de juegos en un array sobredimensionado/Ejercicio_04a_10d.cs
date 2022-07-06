/*Este programa continua con todo lo hecho anteriormente,creando un menú
en el que podemos seleccionar las diversas opciones que hemos ido creando
hasta que el usuario seleccione la opción de salir*/
using System;

class Ejercicio_04a_010d
{
	enum opciones { INSERTARFINAL=1, INSERTARPOSICION, ELIMINAR, SALIR }
	
	static void Main()
	{
		string [] juegos = new string [100];
		 int cantidad = 0,posicion;
		 string ultimoJuego = "";
		int opcion;
		
		do
		{
			Console.WriteLine("Menú de opciones:");
			Console.WriteLine((int)opciones.INSERTARFINAL + 
				". Añadir juego al final");
			Console.WriteLine((int)opciones.INSERTARPOSICION + 
				". Añadir juego en una posición");
			Console.WriteLine((int)opciones.ELIMINAR + 
				". borrar un juego");
			Console.WriteLine((int)opciones.SALIR + 
				". Salir");
			Console.WriteLine("Elige una opción del menú:");
			
			opcion = Convert.ToInt32(Console.ReadLine());
			
			switch((opciones)opcion)
			{
				case opciones.INSERTARFINAL:
				if(cantidad < juegos.Length)
				{
					Console.WriteLine("Escribe un nuevo videojuego");
					ultimoJuego = Console.ReadLine();
					juegos[cantidad] = ultimoJuego;
					cantidad++;
				}
				 Console.WriteLine("Listado de juegos");
				for(int i = 0; i < cantidad; i++)
				{
					Console.WriteLine(juegos[i]);
				}
				break;
				case opciones.INSERTARPOSICION:
				if (cantidad < juegos.Length)
				Console.WriteLine("escribe la posicion");
				posicion = Convert.ToInt32(Console.ReadLine());
				posicion--;
				if (posicion >=0 && posicion <= cantidad)
				{
					Console.WriteLine("Escribe un nuevo videojuego");
					ultimoJuego = Console.ReadLine();
					if(cantidad < juegos.Length)
					{
						for(int i = cantidad; i > posicion; i--)
						{
							juegos[i] = juegos [i-1];
						}
						juegos[posicion] = ultimoJuego;
						cantidad++;
						Console.WriteLine("Listado de juegos");
						for(int i = 0; i < cantidad; i++)
						{
							Console.WriteLine(juegos[i]);
						}
					}
				}
				 
				break;
				case opciones.ELIMINAR:
				Console.WriteLine("Que posicion quieres borrar:");
				posicion=Convert.ToInt32(Console.ReadLine());
				posicion--;
				if(posicion>=0 &&posicion<cantidad)
				{
					for (int i = posicion; i < cantidad - 1; i++)
					{
						juegos[i] = juegos[i+1];
					}
					cantidad--;
				}
				else
				{
					Console.WriteLine("Posicion erronea o vacia.");
				}
				Console.WriteLine("Listado de juegos");
				for(int i=0;i<cantidad;i++)
				{
					Console.WriteLine(juegos[i]);
				}
				break;
				case opciones.SALIR:
					Console.WriteLine("Has elegido salir");
					break;
				default:
					Console.WriteLine("Opción incorrecta");
					break;
			}
		}
		while(opcion != (int)opciones.SALIR);
	}
} 
