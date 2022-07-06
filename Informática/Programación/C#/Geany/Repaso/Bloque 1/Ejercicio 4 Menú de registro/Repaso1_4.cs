/*
 * Programa que le muestra al usuario un menú de opciones
 * hasta que elija la opción de Salir
 */
using System;

class Repaso1_4
{
	enum opciones { SALIR, INSERTAR, ELIMINAR, BUSCAR }
	
	static void Main()
	{
		int opcion;
		
		do
		{
			Console.WriteLine("Menú de opciones:");
			Console.WriteLine((int)opciones.INSERTAR + 
				". Insertar un nuevo usuario");
			Console.WriteLine((int)opciones.ELIMINAR + 
				". Eliminar un usuario existente");
			Console.WriteLine((int)opciones.BUSCAR + 
				". Buscar un usuario");
			Console.WriteLine((int)opciones.SALIR + 
				". Salir");
			Console.WriteLine("Elige una opción del menú:");
			
			opcion = Convert.ToInt32(Console.ReadLine());
			
			switch((opciones)opcion)
			{
				case opciones.INSERTAR:
					Console.WriteLine("Has elegido insertar");
					break;
				case opciones.ELIMINAR:
					Console.WriteLine("Has elegido eliminar");
					break;
				case opciones.BUSCAR:
					Console.WriteLine("Has elegido buscar");
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
