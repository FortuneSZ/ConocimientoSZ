/* Clase para representar todos los sprites del juego */
class Sprite
{
    // Coordenada X
    protected int x;
    // Coordenada Y
    protected int y;
    // Imagen a dibujar, formada por caracteres
    protected string imagen;

    // Obtiene la coordenada X
    public int GetX()
    {
        return x;
    }

    // Obtiene la coordenada Y
    public int GetY()
    {
        return y;
    }

    // Obtiene la imagen de la nave
    public string GetImagen()
    {
        return imagen;
    }

    // Establece la coordenada X
    public void SetX(int cx)
    {
        x = cx;
    }

    // Establece la coordenada Y
    public void SetY(int cy)
    {
        y = cy;
    }

    // Establece la imagen de la nave
    public void SetImagen(string img)
    {
        imagen = img;
    }

    // Mover el sprite a una nueva posición (cx, cy)
    public void MoverA(int cx, int cy)
    {
        if (cx >= 0 && cx <= Configuracion.ANCHO_PANTALLA - imagen.Length &&
            cy >= 0 && cy < Configuracion.ALTO_PANTALLA)
        {
            // Borramos la posición actual (dibujando espacios)
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < imagen.Length; i++)
                Console.Write(" ");
            // Movemos a esas coordenadas, una vez comprobado que son correctas
            SetX(cx);
            SetY(cy);
        }
    }

    // Dibujar la nave en sus coordenadas actuales
    public virtual void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(imagen);
    }


}
