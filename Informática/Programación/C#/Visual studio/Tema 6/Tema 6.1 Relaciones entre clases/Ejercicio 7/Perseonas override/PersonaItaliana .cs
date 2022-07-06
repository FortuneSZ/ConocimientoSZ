/*Clase PersonaItaliana*/
class PersonaItaliana : Persona
{
    //Constructor
    public PersonaItaliana(string nombre) : base(nombre)
    {
        this.nombre = nombre;
    }

    //Métodos
    public new void Saludar()
    {
        Console.WriteLine("Ciao");
    }
}

