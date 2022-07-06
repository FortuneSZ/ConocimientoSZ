using System;

/*
 * Clase principal para probar trabajadores y proyectos
 */
class Program
{
    static void MostrarTrabajadores(Trabajador[] trabajadores)
    {
        foreach(Trabajador t in trabajadores)
        {
            Console.WriteLine(t);
        }
    }

    static void Titulo(string texto)
    {
        Console.WriteLine(new string('*', texto.Length));
        Console.WriteLine(texto);
        Console.WriteLine(new string('*', texto.Length));
        Console.WriteLine();
    }

    static void Main()
    {
        // Paso 1: Crear array de trabajadores

        Trabajador[] trabajadores = new Trabajador[7];
        trabajadores[0] = new Programador("111A", "Programador1",
            "Java");
        trabajadores[1] = new Programador("222B", "Programador2",
            "C#", (Programador)trabajadores[0]);
        trabajadores[2] = new Analista("333C", "Analista3", 3);
        trabajadores[3] = new Programador("444D", "Programador4",
            "Python");
        trabajadores[4] = new Programador("555E", "Programador5",
            "JavaScript", (Programador)trabajadores[3]);
        trabajadores[5] = new Analista("666F", "Analista6", 6);
        trabajadores[6] = new Programador("777G", "Programador7",
            "C#");

        Titulo("Listado inicial de trabajadores");
        MostrarTrabajadores(trabajadores);


        // Paso 2: Crear proyecto
        string titulo, dniAnalista;
        int horas;
        Analista analistaAsignado = null;

        Titulo("Crear un nuevo proyecto");

        Console.WriteLine("Título del proyecto:");
        titulo = Console.ReadLine();
        Console.WriteLine("Horas estimadas:");
        horas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("DNI del analista asignado:");
        dniAnalista = Console.ReadLine();

        foreach (Trabajador t in trabajadores)
        {
            if (t.Dni == dniAnalista && t is Analista)
                analistaAsignado = (Analista)t;
        }

        if (analistaAsignado != null)
        {
            Proyecto p = new Proyecto(titulo, horas,
                analistaAsignado);
            Console.WriteLine(p);
        }
        else
        {
            Console.WriteLine("Analista no encontrado");
        }

        // Paso 3: Parejas de programadores y programadores sin pareja

        Titulo("Parejas de programadores y programadores sin pareja");

        Console.WriteLine("Parejas de programadores:\n");
        for(int i = 0; i < trabajadores.Length; i++)
        {
            if (trabajadores[i] is Programador && 
                ((Programador)trabajadores[i]).Pareja != null)
            {
                Console.WriteLine(trabajadores[i]);
            }
        }

        Console.WriteLine("Programadores sin pareja:\n");
        for (int i = 0; i < trabajadores.Length; i++)
        {
            if (trabajadores[i] is Programador &&
                ((Programador)trabajadores[i]).Pareja == null)
            {
                Console.WriteLine(trabajadores[i]);
            }
        }

        // Paso 3: Reasignar parejas y mostrar listado

        Titulo("Cambios de parejas en programadores");

        ((Programador)trabajadores[3]).Pareja =
            (Programador)trabajadores[6];
        MostrarTrabajadores(trabajadores);
    }
}
