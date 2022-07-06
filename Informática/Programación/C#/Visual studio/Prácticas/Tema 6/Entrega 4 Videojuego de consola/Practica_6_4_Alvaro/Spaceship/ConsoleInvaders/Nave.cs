using System;

/* Nave principal del juego. Subtipo de Sprite */
class Nave : Sprite
{
    // Disparo de la nave
    protected Disparo[] disparos;
    protected Enemigo[] enemigos;

    // Vidas restantes
    private int vidas;

    // Puntos actuales
    private int puntos;

    // Constructor por defecto
    public Nave()
    : this(Configuracion.ANCHO_PANTALLA / 10, Configuracion.ALTO_PANTALLA - 5)
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
        imagen = ">";
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
                disparos[n].MoverA(x, y);
                disparos[n].SetActivo(true);
                encontrado = true;
            }
            n++;
        }
    }
    // Mueve el disparo hacia la derecha
    public void MoverDisparos()
    {
        for (int i = 0; i < disparos.Length; i++)
        {
            if (disparos[i].GetActivo())
            {
                if (disparos[i].GetX() < Configuracion.ANCHO_PANTALLA-1)
                {
                    disparos[i].MoverA(disparos[i].GetX()+1,
                    disparos[i].GetY());
                } 
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

    //Comprueba si un disparo colisiona con un enemigo
    public void ComprobarColisionConEnemigos(Enemigo e)
    {
        if (e.GetActivo())
        {
            foreach (Disparo d in disparos)
            {
                if (d.GetActivo() && e.GetActivo() && d.ColisionaCon(e))
                {
                    e.SetActivo(false);
                    e.MoverA(Enemigo.INI_X, Enemigo.INI_Y);
                    d.SetActivo(false);
                    d.MoverA(x, y);
                    puntos += Configuracion.PUNTOS_ENEMIGO;
                    /* Segun elimine mas enemigos el jugador
                     * reduciremos la probabilidad de que la
                     * activación de estos fallé, aumentando
                     * la dificultad de la partida.*/
                    if(Configuracion.PROBABILIDAD>2)
                        Configuracion.PROBABILIDAD--;
                }
            }
        }
    }
}
