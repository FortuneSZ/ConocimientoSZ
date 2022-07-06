/*
 * Clase rectángulo (figura geométrica)
 */
class Rectangulo : IFiguraGeometrica
{
    private int baseRect;
    private int alturaRect;

    public Rectangulo(int baseRect, int alturaRect)
    {
        this.baseRect = baseRect;
        this.alturaRect = alturaRect;
    }

    public double CalcularArea()
    {
        return baseRect * alturaRect;
    }

    public double CalcularPerimetro()
    {
        return 2 * baseRect + 2 * alturaRect;
    }
}