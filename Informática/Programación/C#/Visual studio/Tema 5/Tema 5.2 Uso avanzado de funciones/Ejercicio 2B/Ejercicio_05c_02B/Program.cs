/* Programa Fibonacci que devuelva el elemento deseado de la secuencia */

class Ejercicio_05c_02b
{
    static int Fibonacci(int posicion)
    {
        if (posicion == 0 || posicion == 1)
            return posicion;

        return Fibonacci(posicion - 1) + Fibonacci(posicion - 2);
    }

    public static void Main()
    {
        int numero;
        Console.WriteLine("introduce el número de la secuencia que quiera ver");
        numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fibonacci(numero));


    }
}
