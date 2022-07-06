/*Clase puerta*/
class Puerta
{
    private int ancho;
    private int alto;
    private string casa;

    //Getters y setters
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
    public string Casa
    {
        get { return casa; }
        set { casa = value; }
    }

    //Constructor
    public Puerta(int ancho, int alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }
}
