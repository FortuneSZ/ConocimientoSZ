/*
 * Proyectos software
 */
class Proyecto
{
    private string titulo;
    private int horas;
    private Analista analista;

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }

    public int Horas
    {
        get { return horas; }
        set 
        { 
            if (value > 0)
                horas = value; 
        }
    }

    public Analista Analista
    {
        get { return analista; }
        set { analista = value; }
    }

    public Proyecto(string titulo, int horas, 
        Analista analista)
    {
        this.titulo = titulo;
        this.Horas = horas;
        this.analista = analista;
    }

    public override string ToString()
    {
        return titulo + " (" + horas + " horas)\n" +
            analista.ToString();
    }
}