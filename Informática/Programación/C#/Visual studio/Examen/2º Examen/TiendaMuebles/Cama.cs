//Clase Cama
class Cama : Muebles
{

    private string colchon;

    public string Colchon
    {
        get { return colchon; }
        set { colchon = value; }
    }

    public Cama(string codigo, string nombre, float precio, string colchon)
        : base(codigo, nombre, precio)
    {
        this.colchon = colchon;
    }

    public override string ToString()
    {
        return base.ToString() + "-" + colchon;
    }
}
