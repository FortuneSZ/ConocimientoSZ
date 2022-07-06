/*
 * Elementos domóticos de tipo horno
 */
class Horno : ElementoDomotico, IEncendible
{
    private int temperatura;
    private bool encendido;

    public int Temperatura
    {
        get { return temperatura; }
        set 
        { 
            if (value >= 0 && value <= 250)
                temperatura = value; 
        }
    }

    public bool Encendido
    {
        get { return encendido; }
        set { encendido = value; }
    }

    public Horno(string nombre, int temperatura, 
        bool encendido) : base(nombre)
    {
        this.Temperatura = temperatura;
        this.encendido = encendido;
    }

    public override string ToString()
    {
        string texto = "";
        if (encendido)
            texto = "encendido";
        else
            texto = "apagado";

        return base.ToString() + ", " + 
            temperatura + "ºC, " + texto;
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