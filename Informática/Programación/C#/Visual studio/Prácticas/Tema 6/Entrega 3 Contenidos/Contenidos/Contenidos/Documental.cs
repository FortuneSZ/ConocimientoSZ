class Documental : Contenido, IDescargable
{
    private string tematica;
    private int duracionMin;

    public string Tematica
    {
        get
        {
            return tematica;
        }
        set
        {
            tematica = value;
        }
    }

    public int DuracionnMin
    {
        get
        {
            return duracionMin;
        }
        set
        {
            duracionMin = value;
        }
    }

    public Documental(string tematica, int duracionmin, string titulo) : base(titulo)
    {
        this.tematica = tematica;
        this.duracionMin = duracionmin;
        this.Titulo = titulo;
    }
    public override string ToString()
    {
        return "Documental: " + base.ToString() + ", Temática: " + tematica +
            ", " + duracionMin + " Minutos";
    }

    public float calcularTamano()
    {
        return duracionMin * 15;
    }
}
