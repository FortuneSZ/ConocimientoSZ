/*
 * Programador, subtipo de trabajador
 */
class Programador : Trabajador
{
    private string lenguaje;
    private Programador pareja;

    public string Lenguaje
    {
        get { return lenguaje; }
        set { lenguaje = value; }
    }

    public Programador Pareja
    {
        get { return pareja; }

        // Usaremos el setter en el constructor para asignar automáticamente
        // las parejas
        set {
            // Quitamos la pareja actual de this
            if (pareja != null)
                pareja.pareja = null;
            // Asignamos la nueva pareja de this
            pareja = value;
            if (value != null)
            {
                // Quitamos la pareja actual de la otra
                if (value.pareja != null)
                    value.pareja.pareja = null;
                // Asignamos la nueva pareja de la otra (this)
                value.pareja = this;
            }
        }
    }

    public Programador(string dni, string nombre,
        string lenguaje)
    : base(dni, nombre)
    {
        this.lenguaje = lenguaje;
        this.Pareja = null;
    }

    public Programador(string dni, string nombre,
        string lenguaje, Programador pareja) 
    : base(dni, nombre)
    {
        this.lenguaje = lenguaje;
        this.Pareja = pareja;
        pareja.Pareja = this;
    }

    public override string ToString()
    {
        string texto = "No asignada";
        if (pareja != null)
            texto = pareja.Nombre;
        return "Programador " + base.ToString() +
            ", " + lenguaje + "\nPareja:" + 
            texto + "\n";
    }
}