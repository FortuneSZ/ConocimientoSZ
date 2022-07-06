using System;

/*
 * Programa que gestiona un listado de videojuegos
 */ 
class Program
{
    const string FICHERO = "videojuegos.txt";
    static List<Videojuego> CargarVideojuegos()
    {
        List<Videojuego> videojuegos = 
            new List<Videojuego>();
        string linea;

        using(StreamReader fichero = 
            new StreamReader(FICHERO))
        {
            while((linea = fichero.ReadLine()) != null)
            {
                string[] partes = linea.Split(';');
                if (partes.Length == 2)
                {
                    videojuegos.Add(new Videojuego(partes[0], partes[1]));
                }
                else if (partes.Length == 4)
                {
                    videojuegos.Add(new VideojuegoPC(
                        partes[0], partes[1],
                        Convert.ToInt32(partes[2]),
                        Convert.ToInt32(partes[3])));
                }
            }
        }
        return videojuegos;
    }

    static void GuardarVideojuegos(List<Videojuego> lista)
    {
        using(StreamWriter fichero = 
            new StreamWriter(FICHERO))
        {
            foreach(Videojuego videojuego in lista)
            {
                fichero.WriteLine(videojuego.AFichero());
            }
        }
    }


    static void MostrarVideojuegos(List<Videojuego> lista)
    {
        Console.WriteLine("Listado de videojuegos:");
        Console.WriteLine("-----------------------");
        foreach(Videojuego videojuego in lista)
        {
            Console.WriteLine(videojuego);
        }
        Console.ReadLine();
    }

    static int Menu()
    {
        Console.Clear();
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("-----------------");
        Console.WriteLine("1. Añadir videojuego");
        Console.WriteLine("2. Borrar videojuego");
        Console.WriteLine("3. Mostrar videojuegos");
        Console.WriteLine("0. Salir");

        return Convert.ToInt32(Console.ReadLine());
    }

    static void NuevoVideojuego(List<Videojuego> lista)
    {
        string titulo, genero;
        int ram, disco, tipo;

        Console.WriteLine("Tipo: 1. Normal / 2. PC");
        tipo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Título:");
        titulo = Console.ReadLine();
        Console.WriteLine("Género:");
        genero = Console.ReadLine();

        if (tipo == 2)
        {
            Console.WriteLine("Mínima RAM (GB):");
            ram = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mínimo espacio en disco (GB):");
            disco = Convert.ToInt32(Console.ReadLine());
            lista.Add(new VideojuegoPC(titulo, genero,
                ram, disco));
        }
        else
        {
            lista.Add(new Videojuego(titulo, genero));
        }
    }

    static void EliminarVideojuego(List<Videojuego> lista)
    {
        int posicion;

        Console.WriteLine("Posición a borrar:");
        posicion = Convert.ToInt32(Console.ReadLine());

        if (posicion >= 0 && posicion < lista.Count)
        {
            Console.WriteLine("Borrando {0}",
                lista[posicion]);
            lista.RemoveAt(posicion);
        }
        else
        {
            Console.WriteLine("Posición incorrecta");
        }
        Console.ReadLine();
    }

    static void Main()
    {
        int opcion;
        List<Videojuego> videojuegos = CargarVideojuegos();
        MostrarVideojuegos(videojuegos);
        do
        {
            opcion = Menu();
            switch(opcion)
            {
                case 1:
                    NuevoVideojuego(videojuegos);
                    break;
                case 2:
                    EliminarVideojuego(videojuegos);
                    break;
                case 3:
                    MostrarVideojuegos(videojuegos);
                    break;
            }
        }
        while (opcion != 0);

        GuardarVideojuegos(videojuegos);
    }
}