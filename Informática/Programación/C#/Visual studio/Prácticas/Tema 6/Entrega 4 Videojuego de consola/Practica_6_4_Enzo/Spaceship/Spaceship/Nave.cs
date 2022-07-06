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
    : this(Configuracion.ANCHO_PANTALLA - 75, Configuracion.ALTO_PANTALLA - 5)
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

        while (n < disparos.Length && !encontrado)
        {
            if (!disparos[n].GetActivo())
            {
                disparos[n].Mover(x + 1, y );
                disparos[n].SetActivo(true);
                encontrado = true;
            }
            n++;
        }
    }
    public void SumarPuntos()
    {
        puntos+=10;
    }
    public void QuitarVida()
    {
        vidas--;
    }
    public void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(x, y);
        Console.Write(imagen);
    }
}