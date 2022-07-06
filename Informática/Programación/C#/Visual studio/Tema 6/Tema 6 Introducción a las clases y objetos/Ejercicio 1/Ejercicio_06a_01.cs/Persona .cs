/*Clase persona*/
class Persona
{
    private string nombre;

    //Getters y setters
    public void SetNombre(string n)
    {
        this.nombre = n;
    }

    //metodos
    public void saludar()
    {
        Console.WriteLine("Hola, soy " + nombre);
    }
}
