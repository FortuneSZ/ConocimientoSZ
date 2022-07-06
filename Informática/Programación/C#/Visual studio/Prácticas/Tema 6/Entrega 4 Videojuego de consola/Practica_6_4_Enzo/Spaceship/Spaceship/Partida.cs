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
        tecla = Console.ReadKey(true);
        Nave nave = new Nave();
        Enemigo[] enemigos = new Enemigo[Configuracion.CANTIDAD_ENEMIGOS];
        int probabilidad = 10, resultadoRandom;

        for (int i = 0; i < enemigos.Length; i++)
        {
             enemigos[i]=new Enemigo();
        }
        do
        {
            Thread.Sleep(Configuracion.PAUSA_BUCLE);
            resultadoRandom = Configuracion.r.Next
                (Configuracion.PROBABILIDAD_MINIMA_ENEMIGO,
                Configuracion.PROBABILIDAD_MAXIMA_ENEMIGO);

            if (resultadoRandom < probabilidad)
            {
                
                bool creado = false;
                int count = 0;
                while(!creado && count < Configuracion.CANTIDAD_ENEMIGOS)
                {
                    if (!enemigos[count].GetActivo())
                    {
                        enemigos[count].Activar();
                        creado = true;
                    }
                    count++;
                }
            }
            if (nave.GetPuntos() > 50 + probabilidad*10)
            {
                probabilidad+= 10;
            }

            foreach (Enemigo e in enemigos)
            {
                if (e.GetActivo())
                {
                    e.Mover();
                    if (e.GetActivo())
                        e.Dibujar();
                }
            }
            ComprobarColisiones(nave, enemigos);
            if (Console.KeyAvailable)
            {
                while (Console.KeyAvailable)
                {
                    tecla = Console.ReadKey();
                }
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    nave.Mover(nave.GetX(), nave.GetY() - 1);
                }
                else if (tecla.Key == ConsoleKey.DownArrow)
                {
                    nave.Mover(nave.GetX(), nave.GetY() + 1);
                }
                else if (tecla.Key == ConsoleKey.Spacebar)
                {
                    nave.Disparar();
                }
            }
            foreach (Disparo d in nave.GetDisparos())
            {
                if (d.GetActivo())
                {
                    d.Mover();
                    if (d.GetActivo())
                        d.Dibujar();
                }
            }
            ComprobarColisiones(nave, enemigos);
            nave.Dibujar();
            ActualizarHUD(nave);
        }

        while (tecla.Key != ConsoleKey.Escape && nave.GetVidas() > 0);
        Console.Clear();
    }

    /*
     * Actualiza el HUD del juego
     */
    public void ActualizarHUD(Nave nave)
    {
        Console.SetCursorPosition(Configuracion.ANCHO_PANTALLA - 10, 0);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Puntos: {0}", nave.GetPuntos());

        Console.SetCursorPosition(Configuracion.ANCHO_PANTALLA - 10,15);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Vidas: {0}", nave.GetVidas());

        Console.ResetColor();
    }
    private void ComprobarColisiones(Nave nave, Enemigo[]enemigos)
    {
       foreach(Enemigo enemigo in enemigos)
       {
            foreach(Disparo d in nave.GetDisparos())
            {
                if (d.GetX() == enemigo.GetX() && d.GetY() == enemigo.GetY())
                {
                    if (enemigo.GetActivo() && d.GetActivo())
                    {
                        nave.SumarPuntos();
                        enemigo.Desactivar();
                        enemigo.Borrar();

                        d.Borrar();
                        d.Desactivar();
                    }
                }
            }
            if(nave.GetX() == enemigo.GetX() && nave.GetY() == enemigo.GetY()
                && enemigo.GetActivo())
            {
                nave.QuitarVida();
                enemigo.Desactivar();
                enemigo.Borrar();
            }
       }
    }
}
