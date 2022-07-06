using System;

/* Clase enemigo */
class Enemigo:Sprite
{
    private Disparo[] disparos;
    bool activo;
    // Coordenadas base para reposicionar los enemigos
    public const int INI_X = 10;
    public const int INI_Y = 10;
    // Constructor
    public Enemigo()
    {
        imagen = "X";
        activo = false;
        x = Configuracion.ANCHO_PANTALLA-1;
        y = Configuracion.r.Next(2, 16);
    }
    public bool GetActivo()
    {
        return activo;
    }

    // Desactiva el enemigo
    public void SetActivo(bool a)
    {
        activo = a;
    }
    public void IntentarActivacion()
    {
        int num = Configuracion.r.Next(0,Configuracion.PROBABILIDAD);
        if (num == 0)
        {
            activo = true;
            x = 119;
            y = Configuracion.r.Next(2, 16);
        }
    }
        public void Mover()
    {
        if (GetX() >1)
            MoverA(x-1, y);
        else
        {
            MoverA(INI_X, INI_Y);
            SetActivo(false);
        }
    }
    public override void Dibujar()
    {
        if (activo)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            base.Dibujar();
            Console.ResetColor();
        }
    }
}