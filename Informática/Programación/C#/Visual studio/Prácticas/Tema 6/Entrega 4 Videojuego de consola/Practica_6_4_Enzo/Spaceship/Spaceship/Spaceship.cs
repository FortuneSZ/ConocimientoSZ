/*
 * Programa principal de SpaceShip
 */

Bienvenida b;

Console.CursorVisible = false;

do
{
    b = new Bienvenida();
    b.Lanzar();
    if (!b.GetSalir())
    {
        Console.Clear();
        Partida p = new Partida();
        p.Lanzar();
        Console.Clear();
    }
} while (!b.GetSalir());

Console.Clear();