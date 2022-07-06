using System;

class Program
{
    static int Menu()
    {
        Console.WriteLine("Elige una opción:");
        Console.WriteLine("1. Añadir videojuego");
        Console.WriteLine("0. Salir");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void NuevoVideojuego(List<Videojuego> juegos)
    {
        string titulo, genero;
        float precio;

        Console.WriteLine("Título:");
        titulo = Console.ReadLine();
        Console.WriteLine("Género:");
        genero = Console.ReadLine();
        Console.WriteLine("Precio:");
        precio = Convert.ToSingle(Console.ReadLine());

        juegos.Add(new Videojuego(titulo, genero, precio));
    }

    static void MostrarVideojuegos(List<Videojuego> juegos)
    {
        Console.WriteLine("Listado de videojuegos:");
        foreach(Videojuego v in juegos)
        {
            Console.WriteLine(v);
        }
    }

    static void Main()
    {
        List<Videojuego> juegos = Videojuego.LeerVideojuegos();
        int opcion;

        MostrarVideojuegos(juegos);

        do
        {
            opcion = Menu();
            switch (opcion)
            {
                case 1:
                    NuevoVideojuego(juegos);
                    MostrarVideojuegos(juegos);
                    break;
                case 0:
                    if (juegos.Count > 0)
                        Videojuego.GuardarVideojuegos(juegos);
                    break;
            }
        }
        while (opcion != 0);
    }
}