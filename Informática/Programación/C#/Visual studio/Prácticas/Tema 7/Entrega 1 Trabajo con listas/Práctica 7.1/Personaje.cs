/*Clase abstracta personaje*/
abstract class Personaje : IComparable<Personaje>
{
    protected string nombre;
    protected int vida;

    public string Nombre
    {
        get
        {
            return nombre;
        }

        set
        {
            nombre = value;
        }
    }

    public int Vida
    {
        get
        {
            return vida;
        }

        set
        {
            vida = value;
        }
    }

    public Personaje(string nombre, int vida)
    {
        this.nombre = nombre;
        this.vida = vida;
    }

    public override string ToString()
    {
        return "Nombre: " + nombre + ", Puntos de vida: " + vida;
    }

    public int CompareTo(Personaje otro)
    {
        return this.vida.CompareTo(otro.vida);
    }
}
