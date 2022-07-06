/*Clase PersonaInglesa*/
class PersonaInglesa : Persona
{

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
