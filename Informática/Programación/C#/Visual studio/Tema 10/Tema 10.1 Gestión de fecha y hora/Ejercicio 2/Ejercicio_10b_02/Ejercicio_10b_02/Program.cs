/*
 * Programa que muestra el calendario del mes y
 * año indicados por línea de comandos
 */
class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 2)
        {
            int mes = Convert.ToInt32(args[0]);
            int anyo = Convert.ToInt32(args[1]);
            Console.WriteLine("Calendario del {0} del {1}", mes, anyo);
            Console.WriteLine("lu ma mi ju vi sa do");
            DateTime diaActual = new DateTime(anyo, mes, 1);
            DayOfWeek inicio = DayOfWeek.Monday;
            while(inicio != diaActual.DayOfWeek)
            {
                Console.Write("   ");
                inicio++;
                if (inicio > DayOfWeek.Saturday)
                    inicio = DayOfWeek.Sunday;
            }
            while(diaActual.Month == mes)
            {
                Console.Write("{0} ", diaActual.Day.ToString("00"));
                diaActual = diaActual.AddDays(1);
                if (diaActual.DayOfWeek == DayOfWeek.Monday)
                    Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Parámetros incorrectos");
        }
    }
}