/*
 * Subtipo de propiedad: bungalow
 */
class Bungalow : Propiedad
{
    private int terraza;

    public Bungalow(string descripcion, int superficie, int precio, 
        Agente agente, int terraza)
        : base(descripcion, superficie, precio, agente)
    {
        this.terraza = terraza;
    }

    public override string ToString()
    {
        return base.ToString() + " - " + terraza + " m2 terraza\n\t" + agente;
    }
}