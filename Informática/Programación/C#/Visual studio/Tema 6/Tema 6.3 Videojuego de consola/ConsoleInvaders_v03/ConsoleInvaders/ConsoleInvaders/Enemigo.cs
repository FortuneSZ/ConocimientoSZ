/* Enemigos del juego. Subtipo de Sprite */
class Enemigo : Sprite
{
    // Indica si el enemigo está activo o no (porque no aparezca en pantalla
    // o haya sido destruido)
    protected bool activo;

    // Dirección de movimiento: 1 derecha, -1 izquierda
    protected int direccion;

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

    // Mueve al enemigo en la dirección indicada hasta llegar al límite de la 
    // pantalla
    public void Mover()
    {
        if ((x < Configuracion.ANCHO_PANTALLA - imagen.Length && direccion > 0)
            || (x > 0 && direccion < 0))
        {
            // Mover a la derecha o izquierda, según la dirección
            MoverA(x + direccion, y);
        }
        else
        {
            // Cambiar la dirección de movimiento
            direccion = -direccion;
        }
    }
}
