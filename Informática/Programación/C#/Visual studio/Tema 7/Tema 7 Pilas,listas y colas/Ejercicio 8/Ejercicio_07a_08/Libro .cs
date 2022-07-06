//Clase libro
class Libro : IComparable<Libro>
{
    private string titulo;
    private int numpag;

    public Libro(string titulo, int numpag)
    {
        this.titulo = titulo;
        this.numpag = numpag;
    }

    public override string ToString()
    {
        return "Titulo: " + titulo + ", Número de páginas: " + numpag;
    }

    public int CompareTo(Libro l)
    {
        return this.titulo.CompareTo(l.titulo);
    }
}

