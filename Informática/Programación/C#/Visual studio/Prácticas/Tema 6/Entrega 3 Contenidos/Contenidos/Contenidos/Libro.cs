class Libro : Contenido, IDescargable
{
    private int numPaginas;
    private string color;

    public int NumPaginas
    {
        get
        {
            return numPaginas;
        }
        set
        {
            numPaginas = value;
        }
    }

    public string Color
    {
        get
        {
            return color;
        }
        set
        {
            color = value;
        }
    }

    public Libro(int numpaginas, string color, string titulo) : base(titulo)
    {
        this.numPaginas = numpaginas;
        this.color = color;
        this.titulo = titulo;
    }

    public override string ToString()
    {
        return "Libro: " + base.ToString() + ", " + numPaginas + " Páginas, "
            + color;
    }

    public float calcularTamano()
    {
        if (color == "color")
        {
            return numPaginas * 0.03f;
        }
        else
        {
            return numPaginas * 0.01f;
        }
    }
}
