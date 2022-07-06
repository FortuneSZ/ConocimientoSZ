/*Clase libro*/
class Libro
{
    protected string autor;
    protected string titulo;
    protected string ubicacion;
    //Getters y setters
    public string GetAutor()
    {
        return autor;
    }
    public void SetAutor(string au)
    {
        this.autor = au;
    }
    public string GetTitulo()
    {
        return titulo;
    }
    public void SetTitulo(string tit)
    {
        this.titulo = tit;
    }
    public string GetUbicacion()
    {
        return ubicacion;
    }
    public void SetUbicacion(string ub)
    {
        this.ubicacion = ub;
    }
    //constructores
    public Libro()
    {
        this.autor = "Autor";
        this.titulo = "Titulo";
        this.ubicacion = "Ubicacion";
    }
    public Libro(string autor, string titulo, string ubicacion)
    {
        this.autor = autor;
        this.titulo = titulo;
        this.ubicacion = ubicacion;
    }
    //métodos

}

