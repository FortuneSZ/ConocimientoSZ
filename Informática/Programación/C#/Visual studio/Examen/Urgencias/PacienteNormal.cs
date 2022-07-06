/*Clase paciente normal*/
class PacienteNormal : Paciente
{
    private string Cabmed;

    public string cabmed
    {
        get { return Cabmed; }
        set { Cabmed = value; }
    }

    public PacienteNormal(int Numero, string Nombre, int Edad, string Telefono, string Dolencia, string cabmed) : base(Numero, Nombre, Edad, Telefono, Dolencia)
    {
        this.Numero = Numero;
        this.Nombre = Nombre;
        this.Edad = Edad;
        this.Telefono = Telefono;
        this.Dolencia = Dolencia;
        this.cabmed = cabmed;
    }

    public override string ToString()
    {
        return base.ToString() + "\n" + "Medico de cabecera: " + Cabmed;
    }
}
