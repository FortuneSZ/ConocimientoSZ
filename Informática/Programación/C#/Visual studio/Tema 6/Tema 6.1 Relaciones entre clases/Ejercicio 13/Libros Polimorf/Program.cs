/*Este programa crea un un array de tamaño 5 de tipo documento,y el usuario lo
rellena eligiendo si crea libros o documentos,posteriormente se muestran
sus datos,si son libros los muestra su título en rojo junto a sus páginas,
si es un documento solo su título de color normal*/
class Principal
{
    static void CrearLibro(string autor, string titulo, string ubicacion
        , Documento[] documentos, int i)
    {
        int numpag;
        Console.Clear();
        Console.WriteLine("Escriba el número de páginas");
        numpag = Convert.ToInt32(Console.ReadLine());
        Libro l = new Libro(autor, titulo, ubicacion, numpag);
        documentos[i] = l;
    }
    static void CrearDocumento(int eleccion, Documento[] documentos, int i)
    {
        string autor, titulo, ubicacion;
        Console.Clear();
        Console.WriteLine("Escriba el nombre del autor");
        autor = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Escriba el título");
        titulo = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Escriba la ubicación");
        ubicacion = Console.ReadLine();
        Console.Clear();
        if (eleccion == 1)
        {
            CrearLibro(autor, titulo, ubicacion, documentos, i);

        }
        if (eleccion == 2)
        {
            Documento doc = new Documento(autor, titulo, ubicacion);
            documentos[i] = doc;
        }
    }
    static void Main()
    {
        int eleccion;
        Documento[] documentos = new Documento[2];
        for (int i = 0; i < documentos.Length; i++)
        {
            Console.Clear();
            Console.WriteLine("Elija su opción");
            Console.WriteLine("");
            Console.WriteLine("(1) Libro");
            Console.WriteLine("(2) Documento");
            Console.WriteLine("");
            eleccion = Convert.ToInt32(Console.ReadLine());
            CrearDocumento(eleccion, documentos, i);
        }
        for (int i = 0; i < documentos.Length; i++)
        {
            if (documentos[i] is Libro)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(documentos[i]);
            Console.ResetColor();
        }
    }
}