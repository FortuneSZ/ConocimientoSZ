using System;

class Libro
{
    string titulo;
    string autor;
    string ubicacion;

    public string GetTitulo()
    {
        return titulo;
    }
    
     public string GetAutor()
    {
        return autor;
    }
    
     public string GetUbicacion()
    {
        return ubicacion;
    }

    public void SetTitulo(string t)
    {
        titulo = t;
    }
    
    public void SetAutor(string t)
    {
        autor = t;
    }
    
     public void SetUbicacion(string t)
    {
        ubicacion = t;
    }

}
class PruebaLibro
{
    static void Main()
    {
        Libro miLibro = new Libro();
        Console.WriteLine("Introduzca el nombre");
        miLibro.SetTitulo(Console.ReadLine());
        Console.WriteLine("Introduzca el autor");
        miLibro.SetAutor(Console.ReadLine());
        Console.WriteLine("Introduzca la ubicación");
        miLibro.SetUbicacion(Console.ReadLine());
        
        Console.WriteLine("nombre " + miLibro.GetTitulo());
        Console.WriteLine("autor " + miLibro.GetAutor());
        Console.WriteLine("ubicación " + miLibro.GetUbicacion());
    }
}
