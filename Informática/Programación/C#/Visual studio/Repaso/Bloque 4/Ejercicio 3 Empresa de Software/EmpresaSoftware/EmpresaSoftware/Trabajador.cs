/*
 * Clase padre Trabajador
 */
class Trabajador
{
    protected string dni;
    protected string nombre;

    public string Dni
    {
        get { return dni; }
        set { dni = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public Trabajador(string dni, string nombre)
    {
        this.dni = dni;
        this.nombre = nombre;
    }

    public override string ToString()
    {
        return nombre + " (" + dni + ")";
    }
}