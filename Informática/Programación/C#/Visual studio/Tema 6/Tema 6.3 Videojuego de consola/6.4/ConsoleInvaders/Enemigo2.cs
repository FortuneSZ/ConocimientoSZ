/* Subtipo de enemigo con imagen propia */
class Enemigo2 : Enemigo
{
    // Constructor para indicar las coordenadas
    public Enemigo2(int cx, int cy) : base(cx, cy)
    {
        imagen = "XX";
    }

    // Redefinición del método Dibujar
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        base.Dibujar();
        Console.ResetColor();
    }
}
