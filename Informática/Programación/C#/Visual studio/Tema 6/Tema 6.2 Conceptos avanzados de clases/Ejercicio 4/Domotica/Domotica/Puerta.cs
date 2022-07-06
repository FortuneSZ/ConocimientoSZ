/*
 * Elementos domóticos de tipo puerta
 */
class Puerta : ElementoDomotico
{
    private bool bloqueada;

    public bool Bloqueada
    {
        get { return bloqueada; }
        set { bloqueada = value; }
    }

    public Puerta(string nombre, bool bloqueada)
    : base(nombre)
    {
        this.bloqueada = bloqueada;
    }

    public override string ToString()
    {
        string texto;
        if (bloqueada)
            texto = "bloqueada";
        else
            texto = "no bloqueada";

        return base.ToString() + ", " + texto;
    }
}