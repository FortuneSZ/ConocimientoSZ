/*Este programa crea una función que repite el texto introducido por el usuario
el número de veces marcado por el usuario*/

class Ejercicio_05a_03
{
    static void RepetirTexto(string texto, int repeticiones)
    {
        for (int i = 0; i < repeticiones; i++)
        {
            Console.WriteLine(texto);
        }

    }

    static void Main()
    {
        int repeticiones;
        string texto;
        Console.WriteLine("escriba una frase");
        texto = Console.ReadLine();
        Console.WriteLine("escriba el número de repeticiones");
        repeticiones = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        RepetirTexto(texto, repeticiones);

    }

}
