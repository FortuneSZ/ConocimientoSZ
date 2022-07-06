/*Clase persona*/
class Persona
{
    protected string nombre;

    //Getters y setters
    public void SetNombre(string n)
    {
        this.nombre = n;
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
    public void Saludar()
    {
        Console.WriteLine("Hola, soy " + nombre);
    }
}
