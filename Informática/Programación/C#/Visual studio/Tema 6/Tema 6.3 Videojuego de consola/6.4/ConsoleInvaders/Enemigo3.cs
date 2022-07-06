/* Subtipo de enemigo con imagen propia */
class Enemigo3 : Enemigo
{
    // Constructor para indicar las coordenadas
    public Enemigo3(int cx, int cy) : base(cx, cy)
    {
        imagen = ")(";
    }

    // Redefinición del método Dibujar
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        base.Dibujar();
        Console.ResetColor();
    }
}
