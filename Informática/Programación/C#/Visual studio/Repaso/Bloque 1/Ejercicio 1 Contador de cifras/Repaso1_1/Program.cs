/*
 * Programa que le pide al usuario un número y le
 * dice cuántas cifras tiene
 */

class Repaso1_1
{
    static void Main()
    {
        int contador = 0;
        long numero;

        Console.WriteLine("Escribe un número:");
        numero = Convert.ToInt64(Console.ReadLine());

        while (numero > 0)
        {
            numero = numero / 10;
            contador++;
        }

        Console.WriteLine("El número tiene {0} cifras", contador);
    }
}
