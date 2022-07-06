/*
 * Programa que define un struct para almacenar rutinas de running y
 * muestra un menú con opciones al usuario
 */
using System;

class Repaso2_3
{	
	struct rutina
	{
		public string mes;
		public float distancia;
		public int tiempo;
	}
	
	enum opciones { SALIR, NUEVA, MEDIA, TIEMPO }
	
	static void Main()
	{
		string[] meses = { "Enero", "Febrero", "Marzo",
			"Abril", "Mayo", "Junio", "Julio", "Agosto", 
			"Septiembre", "Octubre", "Noviembre", "Diciembre"};
		rutina[] rutinas = new rutina[50];
		rutina nuevaRutina;
		int cantidad = 0, opcion, minTiempo;
		float mediaKm;
		bool correcto;
		
		do
		{
			Console.WriteLine("Elige una opción del menú");
			Console.WriteLine("{0}. Nueva rutina", 
				(int)opciones.NUEVA);
			Console.WriteLine("{0}. Media Km", 
				(int)opciones.MEDIA);
			Console.WriteLine("{0}. Tiempo más corto", 
				(int)opciones.TIEMPO);
			Console.WriteLine("{0}. Salir", 
				(int)opciones.SALIR);
				
			opcion = Convert.ToInt32(Console.ReadLine());
			
			switch((opciones)opcion)
			{
				case opciones.NUEVA:
					if (cantidad < rutinas.Length)
					{
						Console.WriteLine("Mes de la rutina:");
						nuevaRutina.mes = Console.ReadLine();

						Console.WriteLine("Escribe la distancia:");
						nuevaRutina.distancia = 
							Convert.ToSingle(Console.ReadLine());

						Console.WriteLine("Escribe el tiempo:");
						nuevaRutina.tiempo = 
							Convert.ToInt32(Console.ReadLine());
						
						correcto = false;
						foreach(string mes in meses)
						{
							if(nuevaRutina.mes.ToUpper() == mes.ToUpper())
							{
								correcto = true;
							}
						}		
						
						if (correcto && nuevaRutina.distancia > 0
							&& nuevaRutina.tiempo > 0)
						{
							rutinas[cantidad] = nuevaRutina;
							cantidad++;
						}			
						else
						{
							Console.WriteLine("Datos incorrectos");
						}
					}
					else
					{
						Console.WriteLine("No caben más rutinas");
					}
					
					for(int i = 0; i < cantidad; i++)
					{
						Console.Write(rutinas[i].mes + "-");
						Console.Write(rutinas[i].distancia + "-");
						Console.WriteLine(rutinas[i].tiempo);
					}
					break;
					
				case opciones.MEDIA:
					mediaKm = 0;
					for(int i = 0; i < cantidad; i++)
					{
						mediaKm += rutinas[i].distancia;
					}
					mediaKm /= cantidad;
					Console.WriteLine("Media Km = {0}",
						mediaKm.ToString("N2"));
					break;
				
				case opciones.TIEMPO:				
					minTiempo = rutinas[0].tiempo;
					for(int i = 1; i < cantidad; i++)
					{
						if (rutinas[i].tiempo < minTiempo)
						{
							minTiempo = rutinas[i].tiempo;
						}
					}
					Console.WriteLine("Min. tiempo = {0}",
						minTiempo);
					break;

				case opciones.SALIR:
					Console.WriteLine("Hasta pronto");
					break;
					
				default:
					Console.WriteLine("Opción inválida");
					break;
			}
		}
		while(opcion != (int)opciones.SALIR);
	}
} 

