using System;

/* Nave principal del juego. Subtipo de Sprite */
class Nave : Sprite
{
    // Disparo de la nave
    Disparo[] disparos;

    // Constructor por defecto
    public Nave(): this(40, 20)
    {
    }

    // Constructor para establecer la posición
    public Nave(int cx, int cy)
    {
        disparos = new Disparo[Configuracion.MAX_DISPAROS];
        for (int i = 0; i < disparos.Length; i++)
        {
            disparos[i] = new Disparo();
        }
        imagen = "/\\";
        x = cx;
        y = cy;
    }

    // Inicia un disparo si no está activo
    public void Disparar()
    {
        int n = 0;
        bool encontrado = false;

        while(n < disparos.Length && !encontrado)
        {
            if (!disparos[n].GetActivo())
            {
                disparos[n].MoverA(x, y - 1);
                disparos[n].SetActivo(true);
                encontrado = true;
            }
            n++;
        }
    }

    // Mueve el disparo hacia arriba
    public void MoverDisparos()
    {
        for (int i = 0; i < disparos.Length; i++)
        {
            if (disparos[i].GetActivo())
            {
                if (disparos[i].GetY() > 0)
                    disparos[i].MoverA(disparos[i].GetX(), 
                        disparos[i].GetY() - 1);
                else
                {
                    disparos[i].SetActivo(false);
                    disparos[i].MoverA(x, y);
                }
            }
        }
    }

    // Redefinición del método Dibujar
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.White;
        base.Dibujar();
        foreach(Disparo d in disparos)
        {
            d.Dibujar();
        }
        Console.ResetColor();
    }
}