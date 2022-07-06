/*Clase portón*/
class Porton : Puerta
{
    private bool bloqueada;

    //Constructor
    public Porton(int ancho, int alto, string color)
    {
        this.ancho = ancho;
        this.alto = alto;
        this.color = color;
    }

    //Métodos
    public void Bloquear()
    {
        bloqueada = true;
    }

    public void Desbloquear()
    {
        bloqueada = false;
    }
}
