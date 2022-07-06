/*
 * Clase padre de todos los tipos de propiedad
 */
abstract class Propiedad : IComparable<Propiedad>
{
    protected string descripcion;
    protected int superficie;
    protected int precio;
    protected Agente agente;

    public Propiedad(string descripcion, int superficie, int precio,
        Agente agente)
    {
        this.descripcion = descripcion;
        this.superficie = superficie;
        this.precio = precio;
        this.agente = agente;
    }

    public int GetSuperficie()
    {
        return superficie;
    }

    public override string ToString()
    {
        return descripcion + " (" + superficie + " m2, " + precio + " eur)";
    }

    public int CompareTo(Propiedad otra)
    {
        return this.precio.CompareTo(otra.precio);
    }
}