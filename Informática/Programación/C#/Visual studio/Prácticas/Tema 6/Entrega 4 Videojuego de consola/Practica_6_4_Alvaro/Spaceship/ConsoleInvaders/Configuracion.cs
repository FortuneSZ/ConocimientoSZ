using System;

/*
 * Configuración general del juego
 */
class Configuracion
{
    public const int ANCHO_PANTALLA = 120;
    public const int ALTO_PANTALLA = 15;
    public const int PAUSA_BUCLE = 10;
    public const int MAX_DISPAROS = 20;
    public const int VIDAS_INICIALES = 5;
    public const int PUNTOS_ENEMIGO = 10;
    public const int MAX_ENEMIGOS = 50;
    public static int PROBABILIDAD= 10;
    public static Random r = new Random();
}