//Clase receta
class Receta
{
    private string titulo;
    private byte numComensales;
    private DateTime fecha;
    private List<Ingrediente> ingredientes = new List<Ingrediente>();
    private string preparacion;

    public string Preparacion
    {
        get { return preparacion; }
        set { preparacion = value; }
    }

    public Receta(string titulo, byte comensales, DateTime fecha)
    {
        this.titulo = titulo;
        this.numComensales = comensales;
        this.fecha = fecha;
    }

    public void AñadirIngrediente(Ingrediente ingrediente)
    {
        ingredientes.Add(ingrediente);
    }

    public override string ToString()
    {
        return titulo + "\n" + numComensales + " comensales" + "\n"
            + "Fecha prevista: " + fecha + "\n"
            + ingredientes + "\n" + preparacion;
    }

}

