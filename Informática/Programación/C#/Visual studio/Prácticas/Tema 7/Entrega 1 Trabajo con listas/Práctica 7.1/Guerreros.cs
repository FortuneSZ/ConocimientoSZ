/*Clase guerreros*/
class Guerreros : Personaje
{
    private string matespada;

    public string Matespada
    {
        get
        {
            return matespada;
        }
        set
        {
            matespada = value;
        }
    }

    public Guerreros(string nombre, int vida, string matespada)
        : base(nombre, vida)
    {
        this.Nombre = nombre;
        this.Vida = vida;
        this.Matespada = matespada;
    }

    public override string ToString()
    {
        return "Clase: " + "Guerrero, " + base.ToString()
            + ", Material de la espada: " + matespada;
    }
}
