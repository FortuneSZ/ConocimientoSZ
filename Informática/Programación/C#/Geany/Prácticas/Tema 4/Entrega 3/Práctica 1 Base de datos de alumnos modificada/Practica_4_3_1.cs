/*Este programa es un menú que permite añadir alumnos a la base de datos,
eliminarlos,ver todos los alumnos,ver solo los que hayan aprobado,
buscar aquellos que tengan un nombre concreto,ordenarlos alfabéticamente u
ordenarlos por su nota de examen*/
using System;

class Practica_4_3_1
{
	enum menu{SALIR, NUEVO, BORRAR, VER, APROBADOS, PORNOMBRE, ORDENALFA,
        PORNOTAEX}
	struct calificacion
	{
		public float notasteoria;
		public float notaspractica;
	}
	struct alumno
	{
		public string nombre;
		public string email;
		public calificacion calificaciones;
	}	
	static void Main()
	{
		string elecborrar,nombuscar;
		int option,numalum=0,seleccion,numaprobados=0;
		bool encontrado=false;
		alumno [] alumnos = new alumno[50];
		
		do
		{
			Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*");
			Console.WriteLine("^ base de datos de alumnos");
			Console.WriteLine(("* ")+(int)menu.NUEVO + ". NUEVO ALUMNO");
			Console.WriteLine(("^ ")+(int)menu.BORRAR + ". BORRAR ALUMNO");
			Console.WriteLine(("* ")+(int)menu.VER + ". VER ALUMNOS");
			Console.WriteLine(("^ ")+(int)menu.APROBADOS +
			". ALUMNOS APROBADOS");
			Console.WriteLine(("* ")+(int)menu.PORNOMBRE +
			". ALUMNOS POR NOMBRE");
            Console.WriteLine(("^ ")+(int)menu.ORDENALFA + ". ORDENAR "+
            "ALFABÉTICAMENTE");
            Console.WriteLine(("* ")+(int)menu.PORNOTAEX +
			". ALUMNOS POR NOTA DE EXAMEN");
            Console.WriteLine(("^ ")+(int)menu.SALIR + ". SALIR");
			Console.WriteLine("^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*");
			Console.WriteLine("* ELIJA LA OPCIÓN QUE DESEA");
			Console.WriteLine("^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*");
			option = Convert.ToInt32(Console.ReadLine());
			
			switch ((menu)option)
			{
				case menu.SALIR:
					Console.Clear();
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*");
					Console.WriteLine("^ "+"HA SELECCIONADO SALIR");
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*");
					break;
				
				case menu.NUEVO:

					Console.Clear();
					if (numalum < alumnos.Length)
					{
						try
						{
							Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
							+"^*^");
							Console.WriteLine("^ "+
							"INTRODUCE EL NOMBRE DEL ALUMNO");
							Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
							+"^*^");
							alumnos[numalum].nombre = Console.ReadLine();
							Console.Clear();
							
							
							Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
							+"^*");
							Console.WriteLine("^ "+"INTRODUCE EL EMAIL"+
							" DEL ALUMNO");
							Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
							+"^*");
							alumnos[numalum].email = Console.ReadLine();
							Console.Clear();
							
							Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^"
							+"*^");
							Console.WriteLine("^ "+
							"INTRODUCE SUS CALIFICACIONES");
							Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^"
							+"*^");
							Console.WriteLine("Pulse enter para continuar");
							Console.ReadLine();
							Console.Clear();
							
							Console.WriteLine("*^*^*^*^*^");
							Console.WriteLine("^ "+"PRÁCTICA");
							Console.WriteLine("*^*^*^*^*^");
							alumnos[numalum].calificaciones.notaspractica
							=Convert.ToSingle(Console.ReadLine());
							Console.Clear();
							
							Console.WriteLine("*^*^*^*^");
							Console.WriteLine("^ "+"TEORÍA");
							Console.WriteLine("*^*^*^*^");
							alumnos[numalum].calificaciones.notasteoria
							=Convert.ToSingle(Console.ReadLine());
							if(alumnos[numalum].calificaciones.notaspractica<0
							|| alumnos[numalum].calificaciones.
							notaspractica>10
							|| alumnos[numalum].calificaciones.notasteoria<0
							|| alumnos[numalum].calificaciones.notasteoria>10)
							{
								Console.WriteLine("");
								Console.WriteLine("Valores de calificaciones"+
								 " no válidos");
								 alumnos[numalum].nombre ="";
								 alumnos[numalum].email ="";
								 alumnos[numalum].calificaciones.notaspractica
								 =0;
								 alumnos[numalum].calificaciones.
								 notasteoria=0;
								 Console.ReadLine(); 
							}
							else
							{
								numalum++;
							}
						}
						catch (Exception e)
						{
							Console.WriteLine("");
							Console.WriteLine("Error:valores no válidos");
							Console.WriteLine(e.Message);
							Console.ReadLine();
						}
					}
					else
					{
						Console.WriteLine("La base de datos está llena");
					}
					Console.Clear();
					break;
					
				case menu.BORRAR:
				Console.Clear();
                if (numalum>0)
					{
                        Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
                        +"^*^*^*^*^*");
                        Console.WriteLine("^ "+
                        "Seleccione el número que desea borrar");
                        Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
                        +"^*^*^*^*^*");
                        seleccion = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        
                        if (seleccion <=0 || seleccion > numalum)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("número no válido");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("*^*^*^*^*^*^*^*");
                            Console.WriteLine("^ "+"Estás seguro?");
                            Console.WriteLine("*^*^*^*^*^*^*^*");
                            Console.WriteLine("S/N");
                            Console.WriteLine("*^*^*^*^*^*^*^*");
                            elecborrar = Console.ReadLine();
                            Console.Clear();
                            if (elecborrar == "S")
                            {
                                for (int i=seleccion;i<=numalum;i++)
                                {
                                    alumnos[i-1] = alumnos[i];
                                }
                                numalum--;
                                Console.Clear();
                            }
                            else if (elecborrar == "N")
                            {
                                Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
                                Console.WriteLine("Ha denegado la eliminación");
                                Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
                                Console.ReadLine();
                                Console.Clear();
                            
                            }
                            else
                            {
                                Console.WriteLine("Selección no válida");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^");
                        Console.WriteLine("^ "+"no hay nada que borrar");
                        Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^");
                        Console.WriteLine("Pulse enter para continuar");
                        Console.ReadLine();
                        Console.Clear();
                    }
				break;
				
				case menu.VER:
					if (numalum>0)
					{
						Console.Clear();
						Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
						+"^*^*^*");
						Console.WriteLine("alumnos - email - teoría -"+
						" práctica");
						Console.WriteLine("");
						for (int i=0;i<numalum;i++)
						{
							Console.Write(alumnos[i].nombre + " - ");
							Console.Write(alumnos[i].email + " - ");
							Console.Write(alumnos[i].calificaciones.
							notasteoria+ " - ");
							Console.WriteLine(alumnos[i].calificaciones.
							notaspractica);
						}
						Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
						+"^*^*^*");
						Console.WriteLine("Pulse enter para continuar");
						Console.ReadLine();
						Console.Clear();
					}
					else
					{
						Console.Clear();
						Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
						Console.WriteLine("^ "+ "No hay alumnos que mostrar");
						Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
						Console.WriteLine("Pulse enter para continuar");
						Console.ReadLine();
						Console.Clear();
					}
					
				break;
				
				case menu.APROBADOS:
					Console.Clear();
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
					+"^*^*^*");
					 Console.WriteLine("alumnos - email - teoría -"+
					" práctica");
					Console.WriteLine("");
					
					for (int i=0;i<=numalum;i++)
					{
						if (alumnos[i].calificaciones.notasteoria *7/10 +
						alumnos[i].calificaciones.notaspractica *3/10 >=5 &&
						alumnos[i].calificaciones.notasteoria>=4 &&
						alumnos[i].calificaciones.notaspractica>=4)
						{
							Console.Write(alumnos[i].nombre + " - ");
							Console.Write(alumnos[i].email + " - ");
							Console.Write(alumnos[i].calificaciones.
							notasteoria+ " - ");
							Console.WriteLine(alumnos[i].calificaciones.
							notaspractica);
							numaprobados++;
						}
					}
					if (numaprobados==0)
                    {
                        Console.Clear();
                        Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
                        Console.WriteLine("^ "+ "No hay alumnos que mostrar");
                        Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
                        Console.WriteLine("Pulse enter para continuar");
                        Console.ReadLine();
                        Console.Clear();
                    }
					else
					{
						Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
						+"^*^*^*");
						Console.WriteLine("Pulse enter para continuar");
						Console.ReadLine();
						Console.Clear();
					}
					numaprobados=0;
				break;
				
				case menu.PORNOMBRE:
					Console.Clear();
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
					+"^*^");
					Console.WriteLine("^ "+ "introduzca el nombre a buscar");
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
					+"^*^");
					nombuscar = Console.ReadLine();
					Console.Clear();
					
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
					+"^*^*^*");
					 Console.WriteLine("alumnos - email - teoría -"+
					" práctica");
					Console.WriteLine("");
					for (int i=0;i<numalum;i++)
					 {
						if (alumnos[i].nombre.ToUpper().Contains(nombuscar.
						ToUpper()))
						{
							Console.Write(alumnos[i].nombre + " - ");
							Console.Write(alumnos[i].email + " - ");
							Console.Write(alumnos[i].calificaciones.
							notasteoria+ " - ");
							Console.WriteLine(alumnos[i].calificaciones.
							notaspractica);
							encontrado=true;
						}
					}
					if (encontrado==false)
					{
						Console.Clear();
						Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
						Console.WriteLine("^ "+ "No hay alumnos que mostrar");
						Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
						Console.WriteLine("Pulse enter para continuar");
						Console.ReadLine();
						Console.Clear();
					}
					else
					{
						Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
						+"^*^*^*");
						Console.WriteLine("Pulse enter para continuar");
						Console.ReadLine();
						Console.Clear();
					}
				encontrado=false;
				break;	
                
                case menu.ORDENALFA:
                    Console.Clear();
                    if (numalum>0)
					{
                        for (int i = 0; i < numalum-1; i++)
                        {
                            for (int j = i+1; j < numalum; j++)
                            {
                                if (alumnos[i].nombre.CompareTo(alumnos[j].
                                nombre)>0)
                                {
                                    alumno auxiliar = alumnos[i];
                                    alumnos[i] = alumnos[j];
                                    alumnos[j] = auxiliar;
                                }
                            }
                
                        }
                        Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
                        +"^*^*^*");
                         Console.WriteLine("alumnos - email - teoría -"+
                        " práctica");
                        Console.WriteLine("");
                        for (int i=0;i<numalum;i++)
                            {
                                Console.Write(alumnos[i].nombre + " - ");
                                Console.Write(alumnos[i].email + " - ");
                                Console.Write(alumnos[i].calificaciones.
                                notasteoria+ " - ");
                                Console.WriteLine(alumnos[i].calificaciones.
                                notaspractica);
                            }
                        Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
                        +"^*^*^*");
                        Console.WriteLine("Pulse enter para continuar");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
						Console.WriteLine("^ "+ "No hay alumnos que mostrar");
						Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
						Console.WriteLine("Pulse enter para continuar");
						Console.ReadLine();
						Console.Clear(); 
                    }
                break;
                    
                case menu.PORNOTAEX:
                    Console.Clear();
                    if (numalum>0)
					{
                        for (int i = 0; i < numalum; i++)
                        {
                            for (int j = 0; j < numalum - i - 1; j++)
                            {
                                if (alumnos[j].calificaciones.notasteoria <
                                 alumnos[j+1].calificaciones.notasteoria)
                                {
                                    alumno auxiliar = alumnos[j];
                                    alumnos[j] =alumnos[j+1];
                                    alumnos[j+1] = auxiliar;
                                }
                            }
                        }
                        Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
                            +"^*^*^*");
                             Console.WriteLine("alumnos - email - teoría -"+
                            " práctica");
                            Console.WriteLine("");
                            for (int i=0;i<numalum;i++)
                                {
                                    Console.Write(alumnos[i].nombre + " - ");
                                    Console.Write(alumnos[i].email + " - ");
                                    Console.Write(alumnos[i].calificaciones.
                                    notasteoria+ " - ");
                                    Console.WriteLine(alumnos[i].calificaciones.
                                    notaspractica);
                                }
                            Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
                            +"^*^*^*");
                            Console.WriteLine("Pulse enter para continuar");
                            Console.ReadLine();
                            Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
						Console.WriteLine("^ "+ "No hay alumnos que mostrar");
						Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
						Console.WriteLine("Pulse enter para continuar");
						Console.ReadLine();
						Console.Clear(); 
                    }
                break;
            }
        }
		while(option!=(int)menu.SALIR);	
	}
}

