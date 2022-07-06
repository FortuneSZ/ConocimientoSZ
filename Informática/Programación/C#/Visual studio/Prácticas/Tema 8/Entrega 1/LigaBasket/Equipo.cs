// Clase Equipo
class Equipo
{
    private string nombre;
    private int partidosGan;
    private int partidosPer;
    private int puntosFavor;
    private int puntosContra;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int PartidosGan
    {
        get { return partidosGan; }
        set { partidosGan = value; }
    }

    public int PartidosPer
    {
        get { return partidosPer; }
        set { partidosPer = value; }
    }

    public int PuntosFavor
    {
        get { return puntosFavor; }
        set { puntosFavor = value; }
    }

    public int PuntosContra
    {
        get { return puntosContra; }
        set { puntosContra = value; }
    }
    public Equipo(string Nombre)
    {
        this.nombre = Nombre;
        this.partidosGan = 0;
        this.partidosPer = 0;
        this.puntosContra = 0;
        this.puntosFavor = 0;
    }

    public int IncrementoGanados(int partidosGan)
    {
        this.partidosGan++;
        return partidosGan;
    }

    public int IncremwentoPer(int PartidosPer)
    {
        this.partidosPer++;
        return partidosPer;
    }

    public int IncrementPuntFav(int puntosFavor)
    {
        this.puntosFavor = puntosFavor;
        return puntosFavor;
    }

    public int IncrementPuntCont(int puntosContra)
    {
        this.puntosContra = puntosContra;
        return puntosContra;
    }

    public override string ToString()
    {
        return nombre + "   " + partidosGan + " " + partidosPer + " "
            + puntosFavor + " " + puntosContra;
    }
}
