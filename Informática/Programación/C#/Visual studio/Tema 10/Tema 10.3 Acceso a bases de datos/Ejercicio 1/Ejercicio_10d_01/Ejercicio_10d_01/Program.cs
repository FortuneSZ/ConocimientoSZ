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
                    g.CrearVideojuego();
                    break;
                case 2:
                    g.ListarVideojuegos(false);
                    break;
                case 3:
                    g.ListarVideojuegos(true);
                    break;
            }
        }
        while (opcion != 4);

        g.CerrarConexion();
    }
}
