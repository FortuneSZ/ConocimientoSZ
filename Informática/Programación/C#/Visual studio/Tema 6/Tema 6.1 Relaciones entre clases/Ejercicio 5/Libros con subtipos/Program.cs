/*Este programa crea un objeto de tipo documento y otro de objeto libro,
clase hija de decumento,con atributos propios,posteriormente se muestran
sus datos*/
class Principal
{
    static void Main()
    {
        Documento doc = new Documento("Paco", "cosas", "Tumente");
        Console.WriteLine("Autor: " + doc.Autor + ", Titulo: " +
            doc.Titulo + ", Ubicacion: " + doc.Ubicacion);
        Console.WriteLine();
        Libro libro = new Libro("ella", "no", "teama", 50);
        Console.WriteLine("Autor: " + libro.Autor + ", Titulo: " +
            libro.Titulo + ", Ubicacion: " + libro.Ubicacion +
            ", numero de paginas: " + libro.Numpaginas);
    }
}