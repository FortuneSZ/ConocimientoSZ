/*
 * Programa que le pide al usuario un número N y muestra
 * la secuencia hasta y desde N
 */

class Repaso1_6
{
    static void Main()
    {
        int n;

        Console.WriteLine("Escribe el valor de N:");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i);
        }

        for (int i = n - 1; i >= 1; i--)
        {
            Console.Write(i);
        }
    }
}
