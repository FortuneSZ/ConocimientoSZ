/*
 * Datos generales de videojuegos
 */
class Videojuego
{
    protected string titulo;
    protected string genero;

    public Videojuego(string titulo, string genero)
    {
        this.titulo = titulo;
        this.genero = genero;
    }

    public override string ToString()
    {
        return titulo + ", " + genero;
    }

    public virtual string AFichero()
    {
        return titulo + ";" + genero;
    }
}