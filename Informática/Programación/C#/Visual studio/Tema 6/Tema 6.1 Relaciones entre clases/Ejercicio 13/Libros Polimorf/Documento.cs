/*Clase documento*/
class Documento
{
    protected string autor;
    protected string titulo;
    protected string ubicacion;

    //Getters y setters

    public string Autor
    {
        get { return autor; }
        set { titulo = value; }
    }
    public string Titulo
    {
        get { return titulo; }
        set { ubicacion = value; }
    }
    public string Ubicacion
    {
        get { return ubicacion; }
        set { ubicacion = value; }
    }

    //Constructores
    public Documento()
    {
        this.autor = "Autor";
        this.titulo = "Titulo";
        this.ubicacion = "Ubicacion";
    }

    public Documento(string autor, string titulo, string ubicacion)
    {
        this.autor = autor;
        this.titulo = titulo;
        this.ubicacion = ubicacion;
    }
    public override string ToString()
    {
        return titulo;
    }
}
