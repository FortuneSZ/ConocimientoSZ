/*Clase libro*/
class Libro
{
    private string autor;
    private string titulo;
    private string ubicacion;

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
    //métodos

}
