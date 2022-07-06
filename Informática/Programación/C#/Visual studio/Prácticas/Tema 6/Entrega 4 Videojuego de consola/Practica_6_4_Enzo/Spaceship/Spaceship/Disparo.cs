using System;

/* Clase para representar los disparos de las naves */
class Disparo : Sprite
{
    private bool activo;

    public Disparo()
    {
        activo = false;
        imagen = "-";
    }

    // Establecer el disparo como activo o no
    public void SetActivo(bool a)
    {
        activo = a;
    }

    // Obtener si el disparo está activo o no
    public bool GetActivo()
    {
        return activo;
    }

    public void Mover()
    {
        if (x + 1 >= Configuracion.ANCHO_PANTALLA)
        {
            activo = false;
            Borrar();
        }
        else
        {
            base.Mover(x + 1, y);
        }
    }
    public void Desactivar()
    {
        activo = false;
    }
    public void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(x, y);
        Console.Write(imagen);
    }

}
