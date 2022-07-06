//Clase artículo
class Articulo : Documento
{
    private string procedencia;

    public Articulo(string autor, string titulo, string ubicacion
        , string procedencia) : base(autor, titulo, ubicacion)
    {
        this.autor = autor;
        this.titulo = titulo;
        this.ubicacion = ubicacion;
        this.procedencia = procedencia;
    }

    public override string ToString()
    {
        return base.ToString() + ", Procedencia: " + procedencia;
    }
}

