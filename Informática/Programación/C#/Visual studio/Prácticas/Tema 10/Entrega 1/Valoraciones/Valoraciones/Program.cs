using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

enum Valoracion
{
    MALA, REGULAR, BUENA, MUY_BUENA, EXCELENTE
}
class Program
{
    const string FICHERO = "valoraciones.txt";
    static List<Usuario> CargarValoraciones()
    {
        List<Usuario> resultado = new List<Usuario>();
        if (File.Exists(FICHERO))
        {
            using (StreamReader fichero = new StreamReader(FICHERO))
            {
                string linea;
                while ((linea = fichero.ReadLine()) != null)
                {
                    string[] partes = linea.Split(';');

                    resultado.Add(new Usuario(partes[0], partes[1],
                        DateTime.ParseExact(partes[2], "dd/MM/yyyy", null),
                        (Valoracion)Convert.ToInt32(partes[3])));
                }
            }
        }
        return resultado;
    }

    static void GuardarValoraciones(List<Usuario> valoraciones)
    {
        using (StreamWriter fichero = new StreamWriter(FICHERO))
        {
            foreach (Usuario u in valoraciones)
            {
                fichero.WriteLine(u.PasarFormato());
            }
        }
    }

    static void CalcularPorcentajes(List<Usuario> valoraciones)
    {
        double porcentaje;
        Console.WriteLine("Porcentajes de valoraciones:");
        foreach (Valoracion va in Enum.GetValues(typeof(Valoracion)))
        {
            porcentaje =
            valoraciones.Where
            (v => v.Valoracion == va).Count()
            * 100 / valoraciones.Count;
            Console.WriteLine("{0}% {1}", porcentaje, va);
        }     
        Console.WriteLine();
    }

    static void NombresExcelente(List<Usuario> valoraciones)
    {
        List<string> nombres = valoraciones.Where
            (v => v.Valoracion == Valoracion.EXCELENTE).Select
            (v => v.Nombre).ToList();
        string nombresUnidos = String.Join(", ", nombres);
        Console.WriteLine("Nombres de los usuarios (EXCELENTE)");
        Console.WriteLine(nombresUnidos);
        Console.WriteLine();
    }

    static void UsuariosOrdenados(List<Usuario> usuarios)
    {
        usuarios.Sort((u1, u2) => u2.FechaNac.CompareTo(u1.FechaNac));
        Console.WriteLine("Listado ordenado por edad");
        foreach(Usuario usario in usuarios)
        {
            Console.WriteLine(usario.Nombre);
        }
        Console.WriteLine();
    }

    static void DiferenciaDeDias(List<Usuario> usuarios)
    {
        TimeSpan diferencia =
            usuarios[0].FechaNac.Subtract
            (usuarios[usuarios.Count-1].FechaNac);
        Console.WriteLine("Diferencia de días entre el" +
            " usuario más joven y el más viejo: {0}", diferencia.Days);
    }

    static void AnyadirUsuario(List<Usuario> valoraciones)
    {
        string nombre, email;
        DateTime fechaNac = DateTime.Now;
        int valoracion = 0;
        bool errores = false;
        do
        {
            Console.WriteLine("Escribe el nombre o nada para terminar:");
            nombre = Console.ReadLine();
            if (nombre != "")
            {
                Console.WriteLine("Escribe el e-mail:");
                email = Console.ReadLine();
                Console.WriteLine("Escribe la fecha de naciento:");
                try
                {
                    fechaNac = DateTime.ParseExact
                        (Console.ReadLine(), "dd/MM/yyyy", null);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Fecha inválida");
                    errores = true;
                }
                if (!errores)
                {
                    try
                    {
                        Console.WriteLine("Escribe la valoracion (1-5)");
                        valoracion = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Valoración inválida");
                        errores = true;
                    }
                }
                if (!errores)
                    valoraciones.Add(new Usuario(nombre, email,
                        fechaNac, (Valoracion)valoracion - 1));
            }
        }
        while (nombre != "");
        Console.Clear();
    }

    static void Main(string[] args)
    {
        List<Usuario> valoraciones = CargarValoraciones();
        AnyadirUsuario(valoraciones);
        GuardarValoraciones(valoraciones);
        CalcularPorcentajes(valoraciones);
        NombresExcelente(valoraciones);
        UsuariosOrdenados(valoraciones);
        DiferenciaDeDias(valoraciones);
    }
}