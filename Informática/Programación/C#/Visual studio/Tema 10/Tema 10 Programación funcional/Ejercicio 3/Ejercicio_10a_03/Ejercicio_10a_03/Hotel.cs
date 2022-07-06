/*
 * Datos de los hoteles
 */
class Hotel
{
    private string nombre;
    private string localidad;
    private int estrellas;

    public string Nombre
    {
        get { return nombre; }
    }

    public string Localidad
    {
        get { return localidad; }
    }

    public int Estrellas
    {
        get { return estrellas; }
    }

    public Hotel(string nombre, string localidad, int estrellas)
    {
        this.nombre = nombre;
        this.localidad = localidad;
        this.estrellas = estrellas;
    }

    public override string ToString()
    {
        return nombre + ", " + localidad + ", " + estrellas;
    }
}