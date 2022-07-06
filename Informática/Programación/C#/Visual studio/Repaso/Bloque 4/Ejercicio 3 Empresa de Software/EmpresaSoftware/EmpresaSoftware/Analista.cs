/*
 * Analista, subtipo de Trabajador
 */
class Analista : Trabajador
{
    private int experiencia;

    public int Experiencia
    {
        get { return experiencia; }
        set { experiencia = value; }
    }

    public Analista(string dni, string nombre, 
        int experiencia): base(dni, nombre)
    {
        this.experiencia = experiencia;
    }

    public override string ToString()
    {
        return "Analista " + base.ToString() +
            ", " + experiencia + " años exper.\n";
    }
}