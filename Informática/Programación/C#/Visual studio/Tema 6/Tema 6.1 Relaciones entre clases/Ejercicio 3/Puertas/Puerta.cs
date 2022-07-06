/*Clase puerta*/
class Puerta
{
    protected int ancho;
    protected int alto;
    protected string color;
    protected bool abierta;

    //Constructores
    public Puerta()
    {
        ancho = 0;
        alto = 0;
        color = "blanco";
        abierta = false;
    }

    public Puerta(int ancho, int alto, string color)
    {
        this.ancho = ancho;
        this.alto = alto;
        this.color = color;
    }

    //Métodos
    public void Abrir()
    {
        abierta = true;
    }

    public void Cerrar()
    {
        abierta = false;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Alto: {0}", alto);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Abierta: {0}", abierta);
    }

    // Getters & setters

    public int Ancho
    {
        get { return ancho; }
        set { ancho = value; }
    }
    public int Alto
    {
        get { return alto; }
        set { alto = value; }
    }
}

