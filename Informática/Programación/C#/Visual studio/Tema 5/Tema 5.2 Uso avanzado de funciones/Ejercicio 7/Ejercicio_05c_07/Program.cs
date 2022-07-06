/* 
 * Programa que define una función que dibuja un recuadro
 * en pantalla con parámetros por defecto
 */

class Ejercicio_05c_07
{
    static void DibujarRecuadro(int anchura, int altura = 3,
        char relleno = '*')
    {
        for (int i = 0; i < altura; i++)
        {
            Console.WriteLine(new string(relleno, anchura));
        }
    }

    static void Main()
    {
        Console.WriteLine("Recuadro de 5 x 4 con guiones:");
        DibujarRecuadro(5, 4, '-');
        Console.WriteLine("Recuadro de 4 x 6:");
        DibujarRecuadro(4, 6);
        Console.WriteLine("Recuadro de ancho 6:");
        DibujarRecuadro(6);
    }
}
