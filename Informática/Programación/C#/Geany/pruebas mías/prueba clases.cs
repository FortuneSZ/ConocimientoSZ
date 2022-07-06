using System;

class Libro
{
    string titulo;
    int numPaginas=0;
    double precio=0;

    public string GetTitulo()
    {
        return titulo;
    }

    public void SetTitulo(string t)
    {
        titulo = t;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Información del libro:");
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Páginas: " + numPaginas);
        Console.WriteLine("Precio: " + precio);
    }
}

class Principal
{
    static void Main()
    {
        Libro miLibro = new Libro();
        miLibro.SetTitulo("El juego de Ender");
        miLibro.MostrarInformacion();
    }
}
