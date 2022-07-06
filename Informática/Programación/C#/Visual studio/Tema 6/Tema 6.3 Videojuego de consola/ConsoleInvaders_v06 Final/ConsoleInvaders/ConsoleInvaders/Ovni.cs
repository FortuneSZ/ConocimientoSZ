using System;

/* Tipo especial de enemigo que aparece ocasionalmente por la parte superior de 
 * la pantalla */
class Ovni : Enemigo
{
    // Coordenadas de inicio de movimiento
    public const int INI_X = 0;
    public const int INI_Y = 2;

    // Constructor
    public Ovni()
    {
        imagen = "[-]";
        activo = false;
    }

    // Genera un número aleatorio que decide si activa o no el ovni
    public void IntentarActivacion()
    {
        int num = Configuracion.r.Next(0, 10);
        // Hacemos que, por ejemplo, el ovni se active sólo el 10% de las veces
        if (num == 0)
        {
            activo = true;
            x = INI_X;
            y = INI_Y;
        }
    }

    // Mueve el ovni una posición a la derecha
    public void Mover()
    {
        if (GetX() < Configuracion.ANCHO_PANTALLA - imagen.Length)
            MoverA(x + 1, y);
        else
        {
            MoverA(INI_X, INI_Y);
            SetActivo(false);
        }
    }
    // Redefinición del método Dibujar para el ovni
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