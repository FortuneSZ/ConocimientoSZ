using System;

/*
 * Clase para gestionar la partida principal
 */ 
class Partida
{
    
    // Lanza la partida principal
    public void Lanzar()
    {
        Console.SetCursorPosition(0, 1);
        Console.ForegroundColor = (ConsoleColor)Configuracion.r.Next(1, 3);
        Console.Write("[][][][][][][]][]][][][][][][][][][][][]" +
            "[]][]][][][][][][][][][][][][]][]][][][][][][][][][][]" +
            "[][]][]][][][][][][][][][][]");
        Console.SetCursorPosition(120, 2);
        Console.WriteLine("[]");
        Console.SetCursorPosition(120, 3);
        Console.WriteLine("[]");
        Console.SetCursorPosition(120, 4);
        Console.WriteLine("[]");
        Console.SetCursorPosition(120, 5);
        Console.WriteLine("[]");
        Console.SetCursorPosition(120, 6);
        Console.WriteLine("[]");
        Console.SetCursorPosition(120, 7);
        Console.WriteLine("[]");
        Console.SetCursorPosition(120, 8);
        Console.WriteLine("[]");
        Console.SetCursorPosition(120, 9);
        Console.WriteLine("[]");
        Console.SetCursorPosition(120, 10);
        Console.WriteLine("[]");
        Console.SetCursorPosition(120, 11);
        Console.WriteLine("[]");
        Console.SetCursorPosition(120, 12);
        Console.WriteLine("[]");
        Console.SetCursorPosition(120, 13);
        Console.WriteLine("[]");
        Console.SetCursorPosition(120, 14);
        Console.WriteLine("[]");
        Console.SetCursorPosition(120, 15);
        Console.WriteLine("[]");
        Console.SetCursorPosition(0, Configuracion.ALTO_PANTALLA + 1);
        Console.WriteLine("[][][][][][][]][]][][][][][][][][][][][]" +
           "[]][]][][][][][][][][][][][][]][]][][][][][][][][][][]" +
           "[][]][]][][][][][][][][][][]");
        Enemigo[] enemigos = new Enemigo[Configuracion.MAX_ENEMIGOS];
        for(int i=0;i<enemigos.Length;i++)
        {
            enemigos[i] = new Enemigo();
        }
        ConsoleKeyInfo tecla = new ConsoleKeyInfo();
        Nave nave = new Nave();
        do
        {
            foreach(Enemigo e in enemigos)
            {
                    e.Dibujar();
            }
            nave.Dibujar();
            Thread.Sleep(Configuracion.PAUSA_BUCLE);
            if (Console.KeyAvailable)
            {
                while (Console.KeyAvailable)
                {
                    tecla = Console.ReadKey(true);
                }
                if (tecla.Key == ConsoleKey.RightArrow ||
                    tecla.Key ==ConsoleKey.D)
                {
                    nave.MoverA(nave.GetX()+1, nave.GetY());
                }
                else if (tecla.Key == ConsoleKey.LeftArrow ||
                    tecla.Key == ConsoleKey.A)
                {
                    nave.MoverA(nave.GetX()-1, nave.GetY());
                }
                
                else if (tecla.Key == ConsoleKey.UpArrow ||
                    tecla.Key == ConsoleKey.W)
                {
                    nave.MoverA(nave.GetX(), nave.GetY()-1);
                }
                else if (tecla.Key == ConsoleKey.DownArrow ||
                    tecla.Key == ConsoleKey.S)
                {
                    nave.MoverA(nave.GetX(), nave.GetY()+1);
                }
                else if (tecla.Key == ConsoleKey.Q)
                {
                    Console.ReadKey(true);
                }
                else if (tecla.Key == ConsoleKey.Spacebar)
                {
                    nave.Disparar();
                }

            }
            foreach (Enemigo e in enemigos)
            {
                if (e.GetActivo())
                {
                    nave.ComprobarColisionConEnemigos(e);
                    if (nave.ColisionaCon(e))
                    {
                        nave.SetVidas(nave.GetVidas() - 1);
                        e.SetActivo(false);
                    }             
                   e.Mover();
                    
                }
                else
                    e.IntentarActivacion();
            }
            nave.MoverDisparos();
            
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
        Console.SetCursorPosition(Configuracion.ANCHO_PANTALLA-10, 0);
        Console.ForegroundColor = (ConsoleColor)Configuracion.r.Next(1, 16);
        Console.WriteLine("Puntos: {0}", nave.GetPuntos());
        
        Console.SetCursorPosition(Configuracion.ANCHO_PANTALLA - 10,
            Configuracion.ALTO_PANTALLA+2);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("Vidas: {0}", nave.GetVidas());
     
        Console.ResetColor();
    }
}
