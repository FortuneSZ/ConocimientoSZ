class Tutorial : Contenido
{
    private int numSesiones;

    public int NumSesiones
    {
        get
        {
            return numSesiones;
        }
        set
        {
            numSesiones = value;
        }
    }

    public Tutorial(int numsesiones, string titulo) : base(titulo)
    {
        this.numSesiones = numsesiones;
        this.Titulo = titulo;
    }

    public override string ToString()
    {
        return "Tutorial: " + base.ToString() + ", " + numSesiones + " Sesiones";
    }
}
