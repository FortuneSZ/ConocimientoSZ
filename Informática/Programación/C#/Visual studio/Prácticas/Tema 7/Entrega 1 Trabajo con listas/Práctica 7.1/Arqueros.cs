/*Clase arqueros*/
class Arqueros : Personaje
{
    private int longarco;

    public int Longarco
    {
        get
        {
            return longarco;
        }

        set
        {
            longarco = value;
        }
    }

    public Arqueros(string nombre, int vida, int longarco) : base(nombre, vida)
    {
        this.longarco = longarco;
        this.nombre = nombre;
        this.vida = vida;
    }

    public override string ToString()
    {
        return "Clase: " + "Arquero, " + base.ToString() +
            ", Longitud del arco: " + longarco;
    }
}
