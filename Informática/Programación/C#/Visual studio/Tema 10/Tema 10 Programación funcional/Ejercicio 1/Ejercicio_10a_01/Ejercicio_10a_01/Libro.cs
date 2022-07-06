/*
 * Clase con los datos de los libros
 */
class Libro
{
    private string titulo;
    private string autor;
    private float precio;

    public float Precio
    {
        get { return precio; }
    }

    public Libro(string titulo, string autor, float precio)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.precio = precio;
    }

    public override string ToString()
    {
        return titulo + ", " + autor + ", " + precio;
    }
}