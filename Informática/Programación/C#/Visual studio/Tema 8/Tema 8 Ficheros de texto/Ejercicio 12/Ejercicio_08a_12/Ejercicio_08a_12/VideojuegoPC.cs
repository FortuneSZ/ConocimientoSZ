/*
 * Subtipo de videojuego para PC
 */
class VideojuegoPC : Videojuego
{
    private int minRAM;
    private int minHD;

    public VideojuegoPC(string titulo, string genero,
        int minRAM, int minHD) : base(titulo, genero)
    {
        this.minRAM = minRAM;
        this.minHD = minHD;
    }

    public override string ToString()
    {
        return base.ToString() + ", " + minRAM + "GB RAM, " +
            minHD + "GB HD";
    }

    public override string AFichero()
    {
        return base.AFichero() + ";" + minRAM + ";" + minHD;
    }
}