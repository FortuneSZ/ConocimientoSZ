/*Clase PersonaInglesa*/
class PersonaInglesa : Persona
{
    private string nombre;

    //Constructor
    public PersonaInglesa(string nombre) : base(nombre)
    {
        this.nombre = nombre;
    }

    //Métodos
    public void TomarTe()
    {
        Console.WriteLine("Estoy tomando té");
    }
}
