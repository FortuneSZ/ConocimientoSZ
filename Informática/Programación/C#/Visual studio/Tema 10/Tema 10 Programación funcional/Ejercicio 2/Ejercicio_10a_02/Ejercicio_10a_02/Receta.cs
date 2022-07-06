/*
 * Datos de cada receta
 */
class Receta
{
    private string nombre;
    private string categoria;
    private int calorias;

    public string Nombre
    {
        get { return nombre; }
    }

    public string Categoria
    {
        get { return categoria; }
    }

    public int Calorias
    {
        get { return calorias; }
    }

    public Receta(string nombre, string categoria, int calorias)
    {
        this.nombre = nombre;
        this.categoria = categoria;
        this.calorias = calorias;
    }

    public override string ToString()
    {
        return nombre + ", " + categoria + ", " + calorias;
    }
}