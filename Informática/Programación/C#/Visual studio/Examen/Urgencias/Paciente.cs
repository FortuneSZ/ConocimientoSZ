/*Clase abstracta paciente*/
abstract class Paciente
{
    protected int Numero;
    protected string Nombre;
    protected int Edad;
    protected string Telefono;
    protected string Dolencia;
    protected Diagnostico Diagnost;

    public int numero
    {
        get { return Numero; }
        set { Numero = value; }
    }
    public string nombre
    {
        get { return Nombre; }
        set { Nombre = value; }
    }
    public int edad
    {
        get { return Edad; }
        set { Edad = value; }
    }
    public string telefono
    {
        get { return Telefono; }
        set { Telefono = value; }
    }
    public string dolencia
    {
        get { return Dolencia; }
        set { Dolencia = value; }
    }
    public Diagnostico diagnost
    {
        get { return Diagnost; }
        set { Diagnost = value; }
    }
    public Paciente(int Numero, string Nombre, int Edad, string Telefono, string Dolencia)
    {
        this.Numero = Numero;
        this.Nombre = Nombre;
        this.Edad = Edad;
        this.Telefono = Telefono;
        this.Dolencia = Dolencia;
    }

    public override string ToString()
    {
        return Numero + " - " + Nombre + ", " + Edad + " años, " + Telefono + "\n" + Dolencia;

    }

}
