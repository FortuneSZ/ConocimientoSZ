public class FibonacciIterative
{
    public static int Fibonacci(int posicion)
    {
        int sum1 = 0;
        int sum2 = 1;
        int count = 0;

        if (posicion == 1 || posicion == 0)
            return posicion;

        for (int i = 2; i <= posicion; i++)
        {
            if (count % 2 == 0)
                sum1 += sum2;
            else
                sum2 += sum1;

            count++;
        }

        if (count % 2 == 0)
            return sum2;
        return sum1;
    }

    public static void Main()
    {
        int number = 0;
        Console.WriteLine(Fibonacci(number));

        number = 1;
        Console.WriteLine(Fibonacci(number));

        number = 5;
        Console.WriteLine(Fibonacci(number));
    }
}
