/*
 * Clase para gestionar la partida principal
 */
class Partida
{
    // Lanza la partida principal
    public void Lanzar()
    {
        ConsoleKeyInfo tecla = new ConsoleKeyInfo();
        Nave nave = new Nave();
        Enemigo1 e1 = new Enemigo1(10, 5);
        Enemigo2 e2 = new Enemigo2(10, 7);
        Enemigo3 e3 = new Enemigo3(10, 9);
        Ovni o = new Ovni();

        // Torres defensivas
        TorreDefensiva[] torres = new TorreDefensiva[4];
        for (int i = 0; i < torres.Length; i++)
        {
            torres[i] = new TorreDefensiva(10 + 17 * i, 15);
        }

        o.MoverA(30, 2);

        do
        {
            nave.Dibujar();
            e1.Dibujar();
            e2.Dibujar();
            e3.Dibujar();
            o.Dibujar();

            e1.Mover();
            e2.Mover();
            e3.Mover();

            foreach (TorreDefensiva td in torres)
            {
                td.Dibujar();
            }

            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.LeftArrow)
            {
                nave.MoverA(nave.GetX() - 1, nave.GetY());
            }
            else if (tecla.Key == ConsoleKey.RightArrow)
            {
                nave.MoverA(nave.GetX() + 1, nave.GetY());
            }
        }
        while (tecla.Key != ConsoleKey.Escape);
    }
}
