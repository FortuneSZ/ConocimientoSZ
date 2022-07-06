/*Este programa creará un objeto de tipo libro,le dará valores a sus atgributos
 con los setters y mostrará los datos con los getters*/
class PruebaLibro
{
    static void Main()
    {
        Libro libro = new Libro();
        libro.SetAutor("Kirby");
        libro.SetTitulo("Poio");
        libro.SetUbicacion("Dream land");

        Console.WriteLine("Nombre: " + libro.GetTitulo() + ", Autor: "
            + libro.GetAutor() + ", Ubicación: " + libro.GetUbicacion());
    }
}
