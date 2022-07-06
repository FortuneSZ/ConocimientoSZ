/* 
 * Programa que le pide al usuario un número y le dice si es primo o no
 * usando datos booleanos
 */

using System;

class Ejercicio_03c_07
{
    static void Main()
    {
        int numero, n = 2;
        bool esPrimo = true;

        Console.WriteLine("Escribe un número:");
        numero = Convert.ToInt32(Console.ReadLine());

        while (esPrimo && n < numero / 2)
        {
            if (numero % n == 0)
            {
                esPrimo = false;
            }
            n++;
        }

        if (esPrimo && numero > 1)
        {
            Console.WriteLine("Es primo");
        }
        else
        {
            Console.WriteLine("No es primo");
        }
    }
}
