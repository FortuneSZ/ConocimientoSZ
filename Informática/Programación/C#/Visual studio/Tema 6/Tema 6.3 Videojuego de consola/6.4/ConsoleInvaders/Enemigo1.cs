/* Subtipo de enemigo con imagen propia */
class Enemigo1 : Enemigo
{
    // Constructor para indicar las coordenadas
    public Enemigo1(int cx, int cy) : base(cx, cy)
    {
        imagen = "][";
    }

    // Redefinición del método Dibujar
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        base.Dibujar();
        Console.ResetColor();
    }
}
