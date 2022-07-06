/*
 * Programa principal para gestionar unos videojuegos
 * almacenados en una base de datos, con un menú de opciones
 * para insertar y listar
 */ 
class Program
{
    static void Main()
    {
        int opcion;
        GestionVideojuegos g = new GestionVideojuegos();
        g.CrearConexion();

        do
        {
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1. Nuevo videojuego");
            Console.WriteLine("2. Listar videojuegos");
            Console.WriteLine("3. Videojuegos por precio");
            Console.WriteLine("4. Salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Escribe título:");
                    string titulo = Console.ReadLine();
                    Console.WriteLine("Escribe precio:");
                    float precio = Convert.ToSingle(Console.ReadLine());
                    Videojuego nuevo = new Videojuego(titulo, precio);
                    nuevo.Insertar(g.getConexion());
                    break;
                case 2:
                    List<Videojuego> juegos = Videojuego.Listar(g.getConexion());
                    foreach (Videojuego j in juegos)
                        Console.WriteLine(j);
                    break;
                case 3:
                    Console.WriteLine("Introduce el precio:");
                    float precioMax = Convert.ToSingle(Console.ReadLine());
                    List<Videojuego> juegos2 = Videojuego.Listar(g.getConexion());
                    juegos2 = juegos2.Where(j => j.Precio <= precioMax).ToList();
                    foreach (Videojuego j in juegos2)
                        Console.WriteLine(j);
                    break;
            }
        }
        while (opcion != 4);

        g.CerrarConexion();
    }
}
