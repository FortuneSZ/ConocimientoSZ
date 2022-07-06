/*
 * Rutinas de tipo bicicleta
 */
[Serializable]
class RutinaBicicleta : Rutina
{
    private string origen;
    private string destino;
    private int desnivel;

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

    public int Desnivel
    {
        get { return desnivel; }
        set { desnivel = value; }
    }

    public RutinaBicicleta() { }

    public RutinaBicicleta(string descripcion, DateTime fecha,
        int duracion, int calorias, string origen, string destino,
        int desnivel)
        : base(descripcion, fecha, duracion, calorias)
    {
        this.origen = origen;
        this.destino = destino;
        this.desnivel = desnivel;
    }

    public override string ToString()
    {
        return base.ToString() + "\n" +
            origen + " - " + destino + ", " +
            desnivel + " m. desnivel";
    }
}