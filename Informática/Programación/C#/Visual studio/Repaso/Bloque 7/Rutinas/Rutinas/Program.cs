/*
 * Programa principal de gestión de rutinas
 */
class Program
{
    static int Menu()
    {
        Console.WriteLine("Elige una opción del menú:");
        Console.WriteLine("1. Nueva rutina");
        Console.WriteLine("2. Ver calendario");
        Console.WriteLine("3. Ver rutinas");
        Console.WriteLine("4. Salir");
        return Convert.ToInt32(Console.ReadLine());
    }

    /*
        static void NuevaRutina(List<Rutina> rutinas)
        {
            string descripcion, origen, destino;
            int tipo, duracion, calorias, ejercicios, desnivel;
            DateTime fecha, hoy = DateTime.Now;

            Console.WriteLine("Tipo: 1. Correr / 2. Bici / 3. Circuito");
            tipo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Descripción:");
            descripcion = Console.ReadLine();

            Console.WriteLine("Fecha (dd/mm/aaaa):");
            try
            {
                fecha = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                if (fecha.Month == hoy.Month && fecha.Year == hoy.Year &&
                    rutinas.Where(r => r.Fecha == fecha).Count() == 0)
                {

                    Console.WriteLine("Duración (minutos):");
                    if (Int32.TryParse(Console.ReadLine(), out duracion) &&
                        duracion > 0)
                    {

                        Console.WriteLine("Calorías:");
                        if (Int32.TryParse(Console.ReadLine(), out calorias) &&
                            calorias > 0)
                        {

                            if (tipo == 1 || tipo == 2)
                            {
                                Console.WriteLine("Origen:");
                                origen = Console.ReadLine();
                                Console.WriteLine("Destino:");
                                destino = Console.ReadLine();

                                if (tipo == 2)
                                {
                                    Console.WriteLine("Desnivel máximo:");
                                    desnivel = Convert.ToInt32(Console.ReadLine());
                                    rutinas.Add(new RutinaBicicleta(descripcion, fecha,
                                        duracion, calorias, origen, destino, desnivel));
                                }
                                else
                                {
                                    rutinas.Add(new RutinaCorrer(descripcion, fecha,
                                        duracion, calorias, origen, destino));
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nº ejercicios:");
                                ejercicios = Convert.ToInt32(Console.ReadLine());
                                rutinas.Add(new RutinaCircuito(descripcion, fecha,
                                    duracion, calorias, ejercicios));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Calorías incorrectas");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Duración incorrecta");
                    }
                }
                else
                {
                    Console.WriteLine("Fecha fuera de rango o repetida");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Fecha incorrecta");
            }
        }
    */

    static void NuevaRutina(List<Rutina> rutinas)
    {
        string descripcion, origen, destino;
        int tipo, duracion, calorias, ejercicios, desnivel;
        DateTime fecha, hoy = DateTime.Now;

        Console.WriteLine("Tipo: 1. Correr / 2. Bici / 3. Circuito");
        tipo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Descripción:");
        descripcion = Console.ReadLine();

        Console.WriteLine("Fecha (dd/mm/aaaa):");
        try
        {
            fecha = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            if (fecha.Month != hoy.Month || fecha.Year != hoy.Year ||
                rutinas.Where(r => r.Fecha == fecha).Count() > 0)
            {
                Console.WriteLine("Fecha fuera de rango o repetida");
                return;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Fecha incorrecta");
            return;
        }

        Console.WriteLine("Duración (minutos):");
        if (!Int32.TryParse(Console.ReadLine(), out duracion) ||
            duracion <= 0)
        {
            Console.WriteLine("Duración incorrecta");
            return;
        }

        Console.WriteLine("Calorías:");
        if (!Int32.TryParse(Console.ReadLine(), out calorias) ||
            calorias <= 0)
        {
            Console.WriteLine("Calorías incorrectas");
            return;
        }

        // Todo es correcto

        if (tipo == 1 || tipo == 2)
        {
            Console.WriteLine("Origen:");
            origen = Console.ReadLine();
            Console.WriteLine("Destino:");
            destino = Console.ReadLine();

            if (tipo == 2)
            {
                Console.WriteLine("Desnivel máximo:");
                desnivel = Convert.ToInt32(Console.ReadLine());
                rutinas.Add(new RutinaBicicleta(descripcion, fecha,
                    duracion, calorias, origen, destino, desnivel));
            }
            else
            {
                rutinas.Add(new RutinaCorrer(descripcion, fecha,
                    duracion, calorias, origen, destino));
            }
        }
        else
        {
            Console.WriteLine("Nº ejercicios:");
            ejercicios = Convert.ToInt32(Console.ReadLine());
            rutinas.Add(new RutinaCircuito(descripcion, fecha,
                duracion, calorias, ejercicios));
        }
    }
/* Versión con excepciones en lugar de return
    static void NuevaRutina(List<Rutina> rutinas)
    {
        string descripcion, origen, destino;
        int tipo, duracion, calorias, ejercicios, desnivel;
        DateTime fecha, hoy = DateTime.Now;

        Console.WriteLine("Tipo: 1. Correr / 2. Bici / 3. Circuito");
        tipo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Descripción:");
        descripcion = Console.ReadLine();

        Console.WriteLine("Fecha (dd/mm/aaaa):");
        try
        {
            fecha = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            if (fecha.Month != hoy.Month || fecha.Year != hoy.Year ||
                rutinas.Where(r => r.Fecha == fecha).Count() > 0)
            {
                throw new Exception("Fecha fuera de rango o repetida");
            }

            Console.WriteLine("Duración (minutos):");
            if (!Int32.TryParse(Console.ReadLine(), out duracion) ||
                duracion <= 0)
            {
                throw new Exception("Duración incorrecta");
            }

            Console.WriteLine("Calorías:");
            if (!Int32.TryParse(Console.ReadLine(), out calorias) ||
                calorias <= 0)
            {
                throw new Exception("Calorías incorrectas");
            }

            // Todo es correcto

            if (tipo == 1 || tipo == 2)
            {
                Console.WriteLine("Origen:");
                origen = Console.ReadLine();
                Console.WriteLine("Destino:");
                destino = Console.ReadLine();

                if (tipo == 2)
                {
                    Console.WriteLine("Desnivel máximo:");
                    desnivel = Convert.ToInt32(Console.ReadLine());
                    rutinas.Add(new RutinaBicicleta(descripcion, fecha,
                        duracion, calorias, origen, destino, desnivel));
                }
                else
                {
                    rutinas.Add(new RutinaCorrer(descripcion, fecha,
                        duracion, calorias, origen, destino));
                }
            }
            else
            {
                Console.WriteLine("Nº ejercicios:");
                ejercicios = Convert.ToInt32(Console.ReadLine());
                rutinas.Add(new RutinaCircuito(descripcion, fecha,
                    duracion, calorias, ejercicios));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
    }
*/

    static void VerCalendario(List<Rutina> rutinas)
    {
        int mes = DateTime.Now.Month;
        int anyo = DateTime.Now.Year;
        Console.WriteLine("Calendario del {0} del {1}", mes, anyo);
        Console.WriteLine("lu ma mi ju vi sa do");
        DateTime diaActual = new DateTime(anyo, mes, 1);
        DayOfWeek inicio = DayOfWeek.Monday;
        while (inicio != diaActual.DayOfWeek)
        {
            Console.Write("   ");
            inicio++;
            if (inicio > DayOfWeek.Saturday)
                inicio = DayOfWeek.Sunday;
        }
        while (diaActual.Month == mes)
        {
            PintarDia(diaActual, rutinas);
            diaActual = diaActual.AddDays(1);
            if (diaActual.DayOfWeek == DayOfWeek.Monday)
                Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void PintarDia(DateTime fecha, List<Rutina> rutinas)
    {
        List<Rutina> seleccionada = rutinas.Where(r => r.Fecha == fecha).ToList();
        if (seleccionada.Count > 0)
        {
            if (fecha.CompareTo(DateTime.Now) < 0)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                ElegirColor(seleccionada[0]);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.Write("{0} ", fecha.Day.ToString("00"));
        Console.ResetColor();
    }

    static void VerRutinas(List<Rutina> rutinas)
    {
        List<Rutina> rutinasFuturas =
            rutinas.Where(r => r.Fecha.CompareTo(DateTime.Now) >= 0)
                   .OrderBy(r => r.Fecha)
                   .ToList();
        foreach(Rutina r in rutinasFuturas)
        {
            ElegirColor(r);
            Console.WriteLine(r);
        }
        Console.ResetColor();
    }

    static void ElegirColor(Rutina r)
    {
        if (r is RutinaCorrer)
            Console.ForegroundColor = ConsoleColor.Green;
        else if (r is RutinaBicicleta)
            Console.ForegroundColor = ConsoleColor.Yellow;
        else
            Console.ForegroundColor = ConsoleColor.Blue;
    }

    static void Main()
    {
        int opcion;
        List<Rutina> rutinas = Rutina.LeerRutinas();

        do
        {
            opcion = Menu();
            switch(opcion)
            {
                case 1:
                    NuevaRutina(rutinas);
                    break;
                case 2:
                    Console.Clear();
                    VerCalendario(rutinas);
                    break;
                case 3:
                    Console.Clear();
                    VerRutinas(rutinas);
                    break;
                case 4:
                    Rutina.GuardarRutinas(rutinas);
                    break;
            }
        }
        while (opcion != 4);
    }
}
