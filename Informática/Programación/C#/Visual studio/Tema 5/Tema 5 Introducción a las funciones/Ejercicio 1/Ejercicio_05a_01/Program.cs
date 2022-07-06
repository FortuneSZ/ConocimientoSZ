/*Este programa crea un cuadrado empleando una función externa*/

class Ejercicio_05a_01
{
    static void cuadrado()
    {
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }


    static void Main()
    {
        cuadrado();
    }

}
