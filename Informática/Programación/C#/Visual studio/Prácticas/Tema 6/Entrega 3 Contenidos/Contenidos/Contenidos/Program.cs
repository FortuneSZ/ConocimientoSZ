/*Este programa,pide al usuario rellenar un array de contenido de tamaño 10,
posteriormente lo ordenará y mostrará el contenido del mismo,en colores
distintos dependiendo del tipo de este,luego mostrará los contenidos que son
descargables junto a su peso en mb*/
class Principal
{
    static void colorchose(Contenido[] contenidos, int i)
    {
        if (contenidos[i] is Libro)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        if (contenidos[i] is Documental)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        if (contenidos[i] is Tutorial)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
    static Libro libro()
    {
        Console.WriteLine("Escriba el título del libro");
        string Titulo = Console.ReadLine();
        Console.WriteLine("Escriba el número de páginas del libro");
        int numpag = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escriba si es a color o blanco y negro");
        string color = Console.ReadLine();
        Libro nuevocontenido = new Libro(numpag, color, Titulo);
        return nuevocontenido;
    }

    static Documental documental()
    {
        Console.WriteLine("Escriba el título del documental");
        string Titulo = Console.ReadLine();
        Console.WriteLine("Escriba la temática del documental");
        string tematica = Console.ReadLine();
        Console.WriteLine("Escriba la duración en minutos del documental");
        int durmin = Convert.ToInt32(Console.ReadLine());
        Documental nuevocontenido = new Documental(tematica, durmin, Titulo);
        return nuevocontenido;
    }

    static Tutorial tutorial()
    {
        Console.WriteLine("Escriba el título del tutorial");
        string Titulo = Console.ReadLine();
        Console.WriteLine("Escriba el número de sesiones del documental");
        int numses = Convert.ToInt32(Console.ReadLine());
        Tutorial nuevocontenido = new Tutorial(numses, Titulo);
        return nuevocontenido;
    }
    static void eleccion(Contenido[] Contenidos, int i)
    {
        int eleccion = 0;
        Contenido nuevocontenido;
        Console.WriteLine("Elija el tipo de contenido");
        Console.WriteLine("");
        Console.WriteLine("Presione 1 para seleccionar libro");
        Console.WriteLine("Presione 2 para seleccionar documental");
        Console.WriteLine("Presione 3 para seleccionar tutorial");
        eleccion = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        switch (eleccion)
        {
            case 1:
                Contenidos[i] = libro();
                Console.Clear();
                break;

            case 2:
                Contenidos[i] = documental();
                Console.Clear();
                break;

            case 3:
                Contenidos[i] = tutorial();
                Console.Clear();
                break;
        }
    }
    static void Main()
    {
        Contenido[] contenidos = new Contenido[3];

        for (int i = 0; i < contenidos.Length; i++)
        {
            eleccion(contenidos, i);
        }
        Array.Sort(contenidos);
        for (int i = 0; i < contenidos.Length; i++)
        {
            colorchose(contenidos, i);
            Console.WriteLine(contenidos[i].ToString());
            Console.ResetColor();
        }
        Console.WriteLine("");
        Console.WriteLine("Contenidos descargables");
        for (int i = 0; i < contenidos.Length; i++)
        {
            colorchose(contenidos, i);
            if (contenidos[i] is IDescargable)
            {
                Console.WriteLine(contenidos[i]);
                Console.WriteLine(((IDescargable)contenidos[i]).calcularTamano() + " MB");
                Console.ResetColor();
            }
        }
    }
}
