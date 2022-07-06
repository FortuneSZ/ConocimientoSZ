/*Clase casa*/
class Casa
{
    private string nombre;
    private Puerta puerta1;
    private Puerta puerta2;
    private Puerta puerta3;
    public Casa(string nombre, Puerta p1, Puerta p2, Puerta p3)
    {
        this.nombre = nombre;
        this.puerta1 = p1;
        this.puerta2 = p2;
        this.puerta3 = p3;
    }

    public void MostrarEstado()
    {
        Console.WriteLine(this.nombre);
        Console.WriteLine("Puerta 1 " + "Ancho:" + this.puerta1.Ancho
            + " Alto:" + this.puerta1.Alto);
        Console.WriteLine("Puerta 2 " + "Ancho:" + this.puerta2.Ancho
             + " Alto:" + this.puerta2.Alto);
        Console.WriteLine("Puerta 3 " + "Ancho:" + this.puerta3.Ancho
            + " Alto:" + this.puerta3.Alto);
    }
}
