/*Clase puerta*/
class Puerta
{
    private int ancho;
    private int alto;

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
    public Puerta(int ancho, int alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }
}
