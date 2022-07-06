/* 
 * Programa que define una función que determina cuál es la pieza
 * que falta en un puzzle
 */

class Repaso3_1
{
    static int BuscarPieza(int numPiezas, int[] piezas)
    {
        int resultado = 0;
        int i = 0;
        Array.Sort(piezas);

        while (i < piezas.Length && resultado == 0)
        {
            if (piezas[i] != i + 1)
            {
                resultado = i + 1;
            }
            else
            {
                i++;
            }
        }

        return resultado;
    }

    static int BuscarPieza2(int numPiezas, int[] piezas)
    {
        int sumaTotal = 0, sumaArray = 0;

        for (int i = 1; i <= numPiezas; i++)
        {
            sumaTotal += i;
        }

        for (int i = 0; i < piezas.Length; i++)
        {
            sumaArray += piezas[i];
        }

        return sumaTotal - sumaArray;
    }

    static void Main()
    {
        int[] piezas = { 1, 5, 6, 2, 4, 8, 9, 3, 10 };

        int resultado = BuscarPieza(10, piezas);
        Console.WriteLine("Falta la pieza {0}", resultado);

        int resultado2 = BuscarPieza2(10, piezas);
        Console.WriteLine("Falta la pieza {0}", resultado2);
    }
}
