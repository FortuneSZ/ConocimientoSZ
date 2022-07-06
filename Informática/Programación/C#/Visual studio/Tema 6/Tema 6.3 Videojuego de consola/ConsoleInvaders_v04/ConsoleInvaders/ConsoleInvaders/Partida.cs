using System;

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
        BloqueEnemigos enemigos = new BloqueEnemigos();
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
            enemigos.Dibujar();
            o.Dibujar();
            foreach (TorreDefensiva td in torres)
            {
                td.Dibujar();
            }

            Thread.Sleep(Configuracion.PAUSA_BUCLE);

            if (Console.KeyAvailable)
            {
                while (Console.KeyAvailable)
                {
                    tecla = Console.ReadKey();
                }
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    nave.MoverA(nave.GetX() - 1, nave.GetY());
                }
                else if (tecla.Key == ConsoleKey.RightArrow)
                {
                    nave.MoverA(nave.GetX() + 1, nave.GetY());
                }
            }

            enemigos.Mover();
            // Intentamos activar el ovni si no lo está, y lo movemos si lo está
            if (o.GetActivo())
            {
                o.Mover();
            }
            else
            {
                o.IntentarActivacion();
            }
        }
        while (tecla.Key != ConsoleKey.Escape);

        Console.Clear();
    }
}
