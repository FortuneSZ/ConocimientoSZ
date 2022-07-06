/*Clase mantenimiento*/
class Mantenimiento
{
    private string fecha;
    private string descripcion;
    private float precio;

    public string Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }
    public string Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }
    public float Precio
    {
        get { return precio; }
        set { precio = value; }
    }
    public Mantenimiento(string fecha, string descripcion, float precio)
    {
        this.fecha = fecha;
        this.Descripcion = descripcion;
        this.Precio = precio;
    }
    public override string ToString()
    {
        return "Fecha: " + this.fecha + " , Descripcion: " + this.descripcion
           + " , Precio: " + this.precio;
    }
}
