/*Este programa creará un objeto de tipo libro,le dará valores a sus atributos
 con los constructores y mostrará los datos con los getters*/
class PruebaLibro
{
    static void Main()
    {
        Libro libro = new Libro();
        Libro libro1 = new Libro("Kirby", "Poio", "Dream land");

        Console.WriteLine("Nombre: " + libro.GetTitulo() + ", Autor: "
            + libro.GetAutor() + ", Ubicación: " + libro.GetUbicacion());

        Console.WriteLine("Nombre: " + libro1.GetTitulo() + ", Autor: "
            + libro1.GetAutor() + ", Ubicación: " + libro1.GetUbicacion());
    }
}
