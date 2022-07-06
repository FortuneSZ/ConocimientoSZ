/*
 * Clase para representar al personal del instituto
 */
class Personal
{
    protected string dni;
    protected string nombre;
    protected string telefono;

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

    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }

    public Personal(string dni, string nombre, string telefono)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.telefono = telefono;
    }
}