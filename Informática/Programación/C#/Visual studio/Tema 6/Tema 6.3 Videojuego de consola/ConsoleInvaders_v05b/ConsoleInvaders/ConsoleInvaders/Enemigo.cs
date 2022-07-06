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
        activo = true;
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

    // Dibuja el enemigo (comprueba si está activo para dibujarlo)
    public override void Dibujar()
    {
        if (activo)
            base.Dibujar();
    }
}
