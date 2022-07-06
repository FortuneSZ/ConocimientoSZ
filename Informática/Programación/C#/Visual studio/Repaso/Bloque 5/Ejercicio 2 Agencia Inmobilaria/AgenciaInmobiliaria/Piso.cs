/*
 * Subtipo de propiedad: piso
 */
class Piso : Propiedad
{
    private int habitaciones;
    private int planta;

    public Piso(string descripcion, int superficie, int precio, Agente agente,
        int habitaciones, int planta)
        : base(descripcion, superficie, precio, agente)
    {
        this.habitaciones = habitaciones;
        this.planta = planta;
    }

    public override string ToString()
    {
        return base.ToString() + " - " + habitaciones + " hab, " +
            planta + "ª planta\n\t" + agente;
    }
}