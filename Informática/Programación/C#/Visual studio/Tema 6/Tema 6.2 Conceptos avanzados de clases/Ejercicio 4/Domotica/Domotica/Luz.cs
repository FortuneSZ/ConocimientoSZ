/*
 * Elemento domótico luz
 */
class Luz: ElementoDomotico, IEncendible
{
    private bool encendido;

    public bool Encendido
    {
        get { return encendido; }
        set { encendido = value; }
    }

    public Luz(string nombre, bool encendido)
    : base(nombre)
    {
        this.encendido = encendido;
    }

    public override string ToString()
    {
        string texto = "";
        if (encendido)
            texto = "encendido";
        else
            texto = "apagado";

        return base.ToString() + ", " + texto;
    }

    public void Encender()
    {
        encendido = true;
    }

    public void Apagar()
    {
        encendido = false;
    }
}