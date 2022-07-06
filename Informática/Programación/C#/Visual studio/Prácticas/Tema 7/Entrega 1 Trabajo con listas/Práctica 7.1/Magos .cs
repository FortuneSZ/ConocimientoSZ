/*Clase magos*/
class Magos : Personaje
{
    private int podmagico;

    public int Podmagico
    {
        get
        {
            return podmagico;
        }

        set
        {
            podmagico = value;
        }
    }

    public Magos(string nombre, int vida, int podmagico) : base(nombre, vida)
    {
        this.podmagico = podmagico;
        this.nombre = nombre;
        this.Vida = vida;
    }

    public override string ToString()
    {
        return "Clase: " + "Mago, " + base.ToString() +
            ", Nivel de poder mágico: " + podmagico;
    }
}
