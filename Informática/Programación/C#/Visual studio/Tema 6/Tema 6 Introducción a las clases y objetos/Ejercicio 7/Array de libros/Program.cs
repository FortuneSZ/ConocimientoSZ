/*Este programa creará un array de tipo libro,lo rellenará
le dará valores a sus atributos con los constructores y mostrará los datos con
los getters*/
class PruebaLibro
{
    static void Main()
    {
        Libro[] libro = new Libro[3];
        libro[0] = new Libro("Kirby", "Poio", "Dream land");
        libro[1] = new Libro("namba", "boy", "manambaboy");
        libro[2] = new Libro("ella", "no", "teama");

        for (int i = 0; i < libro.Length; i++)
        {
            Console.WriteLine("Nombre: " + libro[i].GetTitulo() + ", Autor: "
            + libro[i].GetAutor() + ", Ubicación: " + libro[i].GetUbicacion());
        }
    }

}

