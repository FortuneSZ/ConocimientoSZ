abstract class Contenido : IComparable<Contenido>
{
    protected string titulo;

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }

    public Contenido(string titulo)
    {
        this.titulo = titulo;
    }

    public override string ToString()
    {
        return titulo;
    }

    public int CompareTo(Contenido otro)
    {
        return this.titulo.CompareTo(otro.titulo);
    }
}
