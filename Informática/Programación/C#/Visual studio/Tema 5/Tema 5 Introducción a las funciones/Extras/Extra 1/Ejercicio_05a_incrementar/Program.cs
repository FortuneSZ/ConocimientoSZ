/*Este programa crea una función que incrementa un valor*/

class Ejercicio_05a_07
{
    static void incrementar(ref int numero)
    {
        numero++;
        Console.WriteLine("aquí dentro numero es {0}", numero);
    }

    static void Main()
    {
        int numero = 1;
        incrementar(ref numero);
        Console.WriteLine("en el main numero es {0}", numero);
    }

}
