using System;

/* Enemigos del juego. Subtipo de Sprite */
class Enemigo : Sprite
{
    // Indica si el enemigo está activo o no (porque no aparezca en pantalla
    // o haya sido destruido)
    protected bool activo;

    // Constructor por defecto para que puedan compilar las clases hija
    public Enemigo()
    {
        activo = false;
        imagen = "X";
    }

    // Constructor para establecer las coordenadas
    public Enemigo(int cx, int cy)
    {
        activo = true;
        x = cx;
        y = cy;
    }

    // Obtiene si el ovni está activo
    public bool GetActivo()
    {
        return activo;
    }

    // Desactiva el ovni
    public void SetActivo(bool a)
    {
        activo = a;
    }
    public void Mover()
    {
        if (x <= 0)
        {
            activo = false;
            Borrar();
        }
        else
        {
            base.Mover(x - 1, y);
        }
    }
    public void Activar()
    {
        activo = true;
        x = Configuracion.ANCHO_PANTALLA - 2;
        y = Configuracion.r.Next(1,Configuracion.ALTO_PANTALLA);
    }
    public void Desactivar()
    {
        activo = false;
    }
    public void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(x, y);
        Console.Write(imagen);
    }
}
