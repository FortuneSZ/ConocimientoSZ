//Clase Escritorio
class Escritorio : Muebles
{
    private string color;

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public Escritorio(string codigo, string nombre, float precio, string color)
        : base(codigo, nombre, precio)
    {
        this.color = color;
    }

    public override string ToString()
    {
        return base.ToString() + "-" + Color;
    }
}
