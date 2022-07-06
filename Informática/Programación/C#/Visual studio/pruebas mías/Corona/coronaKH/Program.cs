/*Este programa creara una corona en base a la altura suministrada por
el usuario */
class practica_2_3_1
{

    static void Main()
    {
        int altura;
        Console.WriteLine("dime la altura de la corona");
        altura = Convert.ToInt32(System.Console.ReadLine());

        for (int i = 1; i <= altura; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            for (int j = 1; j <= altura - i; j++)
            {
                Console.Write("  ");
            }
            for (int x = 1; x <= i; x++)
            {
                Console.Write("*");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            for (int j = 1; j <= altura - i; j++)
            {
                Console.Write("  ");
            }
            for (int x = 1; x <= i; x++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
