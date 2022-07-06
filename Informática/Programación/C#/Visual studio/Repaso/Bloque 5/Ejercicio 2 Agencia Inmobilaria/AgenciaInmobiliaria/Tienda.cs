/*
 * Subtipo de propiedad: tienda
 */
class Tienda : Propiedad
{
    private bool aseo;

    public Tienda(string descripcion, int superficie, int precio, 
        Agente agente, bool aseo)
        : base(descripcion, superficie, precio, agente)
    {
        this.aseo = aseo;
    }

    public override string ToString()
    {
        return base.ToString() + " - " +
            (aseo ? "con aseo" : "sin aseo") + "\n\t" + agente;
    }
}