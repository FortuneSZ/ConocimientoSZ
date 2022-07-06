/* Tipo especial de enemigo que aparece ocasionalmente por la parte superior de 
   la pantalla */
class Ovni : Enemigo
{
    // Constructor
    public Ovni()
    {
        imagen = "[-]";
    }

    // Redefinición del método Dibujar para el ovni
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        base.Dibujar();
        Console.ResetColor();
    }
}
