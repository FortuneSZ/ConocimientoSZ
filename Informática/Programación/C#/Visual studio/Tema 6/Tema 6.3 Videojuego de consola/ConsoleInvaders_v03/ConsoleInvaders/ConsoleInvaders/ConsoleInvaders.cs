/*
 * Programa principal de ConsoleInvaders
 * Se centra en la lógica de alternar entre pantalla de partida y de bienvenida
 */

Bienvenida b;

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