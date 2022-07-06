//Clase padre mueble
class Muebles
{
    protected string codigo;
    protected string nombre;
    protected float precio;

    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public float Precio
    {
        get { return precio; }
        set { precio = value; }
    }

    public Muebles(string codigo, string nombre, float precio)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.precio = precio;
    }

    public override string ToString()
    {
        return codigo + "-" + nombre + "-" + precio;
    }
}
