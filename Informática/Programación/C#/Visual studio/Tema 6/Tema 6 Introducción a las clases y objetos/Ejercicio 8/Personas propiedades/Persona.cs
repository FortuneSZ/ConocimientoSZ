/*Clase persona*/
class Persona
{
    private string nombre;

    //Getters y setters
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    //Constructores
    public Persona()
    {
    }
    public Persona(string nombre)
    {
        this.nombre = nombre;
    }
    //metodos
    public void saludar()
    {
        Console.WriteLine("Hola, soy " + nombre);
    }
}
