/*Clase libro*/
class Libro : Documento
{
    protected int numpaginas;

    //Getters y setters
    public int Numpaginas
    {
        get { return numpaginas; }
        set { numpaginas = value; }
    }
    //constructores
    public Libro()
    {
        this.autor = "Autor";
        this.titulo = "Titulo";
        this.ubicacion = "Ubicacion";
    }
    public Libro(string autor, string titulo, string ubicacion, int numpag)
        : base(autor, titulo, ubicacion)
    {
        this.autor = autor;
        this.titulo = titulo;
        this.ubicacion = ubicacion;
        this.numpaginas = numpag;
    }
    //métodos
    public override string ToString()
    {
        return base.ToString() + ", " + numpaginas + " páginas";
    }
}
