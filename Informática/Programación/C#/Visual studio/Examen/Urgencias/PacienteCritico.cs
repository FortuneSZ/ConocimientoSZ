/*Clase paciente Crítico*/
class PacienteCritico : Paciente, IComparable<PacienteCritico>
{
    private int Triaje;

    public int triaje
    {
        get { return Triaje; }
        set { Triaje = value; }
    }

    public PacienteCritico(int Numero, string Nombre, int Edad, string Telefono, string Dolencia, int Triaje) : base(Numero, Nombre, Edad, Telefono, Dolencia)
    {
        this.Numero = Numero;
        this.Nombre = Nombre;
        this.Edad = Edad;
        this.Telefono = Telefono;
        this.Dolencia = Dolencia;
        this.Triaje = Triaje;
    }
    public PacienteCritico(int Numero, string Nombre, int Edad, string Telefono, string Dolencia, int Triaje, Diagnostico diagnost) : base(Numero, Nombre, Edad, Telefono, Dolencia)
    {
        this.Numero = Numero;
        this.Nombre = Nombre;
        this.Edad = Edad;
        this.Telefono = Telefono;
        this.Dolencia = Dolencia;
        this.Triaje = Triaje;
        this.Diagnost = diagnost;
    }
    public override string ToString()
    {
        return base.ToString() + "\n" + Triaje;
    }

    public int CompareTo(PacienteCritico j)
    {
        return this.Triaje.CompareTo(j.Triaje);

    }
}
