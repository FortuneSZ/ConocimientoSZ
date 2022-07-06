using System;

/* Nave principal del juego. Subtipo de Sprite */
class Nave : Sprite
{
    // Constructor por defecto
    public Nave(): this(40, 20)
    {
    }

    // Constructor para establecer la posición
    public Nave(int cx, int cy)
    {
        imagen = "/\\";
        x = cx;
        y = cy;
    }

    // Redefinición del método Dibujar
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.White;
        base.Dibujar();
        Console.ResetColor();
    }
}