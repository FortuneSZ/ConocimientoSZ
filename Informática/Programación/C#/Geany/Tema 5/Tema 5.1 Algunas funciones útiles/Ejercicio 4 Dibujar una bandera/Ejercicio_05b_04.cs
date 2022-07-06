/* programa que dibuje la bandera de un pais */

using System;
class Ejercicio_05b_04
{
    static void Main()
    {
        /* Dibujamos fila de 10 asteriscos rojos en línea 3 */
        Console.BackgroundColor = ConsoleColor.DarkRed;
        for(int i = 1; i <= 10; i++)
            Console.Write(" ");
            
        Console.WriteLine();

        Console.BackgroundColor = ConsoleColor.Green;
        for(int i = 1; i <= 10; i++)
            Console.Write(" ");
        
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.White;
        for(int i = 1; i <= 10; i++)
            Console.Write(" ");
            
        Console.ResetColor();
    }
}
