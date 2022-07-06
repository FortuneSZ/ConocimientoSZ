//Clase abstracta alimento
abstract class Alimento
{
    protected string Nombre;

    public Alimento(string nombre)
    {
        this.Nombre = nombre;
    }

    public override string ToString()
    {
        return this.Nombre;
    }
}

