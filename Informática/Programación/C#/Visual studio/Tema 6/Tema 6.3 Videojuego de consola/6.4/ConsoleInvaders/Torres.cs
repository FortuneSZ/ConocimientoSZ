/* Torres defensivas que protegen a la nave de los enemigos. Es un subtipo de 
   sprite, donde la X y la Y representan la esquina superior izquierda de la 
   torre */
using System.Text;
class TorreDefensiva : Sprite
{
    // Ladrillos de la torre, que se van borrando con cada disparo enemigo
    StringBuilder[] ladrillos = {
        new StringBuilder("******"),
        new StringBuilder("******"),
        new StringBuilder("******")
    };

    // Constructor para ubicar la torre en una posición determinada
    public TorreDefensiva(int cx, int cy)
    {
        x = cx;
        y = cy;
    }

    // Dibujar la torre
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        for (int i = 0; i < ladrillos.Length; i++)
        {
            Console.SetCursorPosition(x, y + i);
            Console.Write(ladrillos[i]);
        }
        Console.ResetColor();

    }
}