//clase ingrediente
class Ingrediente
{
    private Alimento alimento;
    private uint cantidad;
    private string unidad;

    public Ingrediente(Alimento alimento, uint cantidad, string unidad)
    {
        this.alimento = alimento;
        this.cantidad = cantidad;
        this.unidad = unidad;
    }

    public override string ToString()
    {
        return alimento + ": " + cantidad + " " + unidad;
    }
}
