//Clase Armario
class Armario : Muebles
{
    private int puertas;

    public int Puertas
    {
        get { return puertas; }
        set { puertas = value; }
    }

    public Armario(string codigo, string nombre, float precio, int puertas)
        : base(codigo, nombre, precio)
    {
        this.puertas = puertas;
    }

    public override string ToString()
    {
        return base.ToString() + "-" + puertas;
    }
}
