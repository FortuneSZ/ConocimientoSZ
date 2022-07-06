using System;

/* Nave principal del juego. Subtipo de Sprite */
class Nave : Sprite
{
    // Disparo de la nave
    private Disparo[] disparos;

    // Vidas restantes
    private int vidas;

    // Puntos actuales
    private int puntos;

    // Constructor por defecto
    public Nave()
    : this(Configuracion.ANCHO_PANTALLA / 2, Configuracion.ALTO_PANTALLA - 5)
    {
    }

    // Constructor para establecer la posición
    public Nave(int cx, int cy)
    {
        vidas = Configuracion.VIDAS_INICIALES;
        puntos = 0;
        disparos = new Disparo[Configuracion.MAX_DISPAROS];
        for (int i = 0; i < disparos.Length; i++)
        {
            disparos[i] = new Disparo();
        }
        imagen = "/\\";
        x = cx;
        y = cy;
    }

    // Getters y setters

    public int GetVidas()
    {
        return vidas;
    }

    public int GetPuntos()
    {
        return puntos;
    }

    public void SetVidas(int vidas)
    {
        this.vidas = vidas;
    }

    public void SetPuntos(int puntos)
    {
        this.puntos = puntos;
    }

    public Disparo[] GetDisparos()
    {
        return disparos;
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

    // Comprueba si los disparos colisionan con alguna torre
    public void ComprobarColisionConTorres(TorreDefensiva[] torres)
    {
        foreach (TorreDefensiva t in torres)
        {
            foreach (Disparo d in disparos)
            {
                if (d.GetActivo() && t.ColisionaCon(d))
                {
                    d.SetActivo(false);
                    d.MoverA(x, y);
                }
            }
        }
    }

    // Comprueba si los disparos colisionan con el ovni
    public void ComprobarColisionConOvni(Ovni o)
    {
        if (o.GetActivo())
        { 
            foreach (Disparo d in disparos)
            {
                if (d.GetActivo() && o.GetActivo() && d.ColisionaCon(o))
                {
                    o.SetActivo(false);
                    o.MoverA(Ovni.INI_X, Ovni.INI_Y);
                    d.SetActivo(false);
                    d.MoverA(x, y);
                    puntos += Configuracion.PUNTOS_OVNI;
                }
            }
        }
    }
}