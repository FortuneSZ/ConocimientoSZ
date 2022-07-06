/*
 * Rutinas de tipo correr
 */
[Serializable]
class RutinaCorrer: Rutina
{
    private string origen;
    private string destino;

    public string Origen
    {
        get { return origen; }
        set { origen = value; }
    }

    public string Destino
    {
        get { return destino; } 
        set { destino = value; }
    }

    public RutinaCorrer() { }

    public RutinaCorrer(string descripcion, DateTime fecha,
        int duracion, int calorias, string origen, string destino)
        : base(descripcion, fecha, duracion, calorias)
    {
        this.origen = origen;
        this.destino = destino;
    }

    public override string ToString()
    {
        return base.ToString() + "\n" +
            origen + " - " + destino;
    }
}