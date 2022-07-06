using System;

/*
 * Configuración general del juego
 */
class Configuracion
{
    public const int ANCHO_PANTALLA = 80;
    public const int ALTO_PANTALLA = 15;
    public const int PAUSA_BUCLE = 70;
    public const int MAX_DISPAROS = 3;
    public const int VIDAS_INICIALES = 3;
    public const int PUNTOS_ENEMIGO1 = 10;
    public const int CANTIDAD_ENEMIGOS = 200;
    public static Random r = new Random();
    public const int PROBABILIDAD_MINIMA_ENEMIGO=0;
    public const int PROBABILIDAD_MAXIMA_ENEMIGO=100;
}