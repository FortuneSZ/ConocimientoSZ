/*
 * Clase para representar distintos elementos domóticos en un hogar
 */
abstract class ElementoDomotico : IComparable<ElementoDomotico>
{
    protected string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public ElementoDomotico(string nombre)
    {
        this.Nombre = nombre;
    }

    public override string ToString()
    {
        return nombre;
    }

    public int CompareTo(ElementoDomotico otro)
    {
        return this.nombre.CompareTo(otro.nombre);
    }
}