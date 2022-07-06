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
    public new void Saludar()
    {
        Console.WriteLine("Hi, I am " + nombre);
    }
}

