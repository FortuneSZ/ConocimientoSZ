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
                else if (tecla.Key == ConsoleKey.Spacebar)
                {
                    nave.Disparar();
                }
            }

            enemigos.Mover();
            enemigos.IntentarDisparo();
            enemigos.MoverDisparos();
            nave.MoverDisparos();

            // Intentamos activar el ovni si no lo está, y lo movemos si lo está
            if (o.GetActivo())
                o.Mover();
            else
                o.IntentarActivacion();

            enemigos.ComprobarColisionConNave(nave);
            enemigos.ComprobarColisionConTorres(torres);
            nave.ComprobarColisionConTorres(torres);
            nave.ComprobarColisionConOvni(o);
            ActualizarHUD(nave);
        }
        while (tecla.Key != ConsoleKey.Escape && nave.GetVidas() > 0 && 
               enemigos.QuedanEnemigos());

        Console.Clear();
    }

    /*
     * Actualiza el HUD del juego
     */ 
    public void ActualizarHUD(Nave nave)
    {
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Puntos: {0}", nave.GetPuntos());

        Console.SetCursorPosition(Configuracion.ANCHO_PANTALLA - 10, 0);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Vidas: {0}", nave.GetVidas());

        Console.ResetColor();
    }
}
