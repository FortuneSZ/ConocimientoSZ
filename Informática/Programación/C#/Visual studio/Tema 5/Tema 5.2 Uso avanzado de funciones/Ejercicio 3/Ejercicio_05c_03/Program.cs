/* Programa funcion InvertirTexto que reciba parametro string y devuelva otro
 * string con el texto invertido */

public class Ejercicio_05c_03
{
    static string Reverse(string entrada)
    {
        if (entrada.Length <= 1)
        {
            return entrada;
        }
        else
        {
            return entrada[entrada.Length - 1] +
                Reverse(entrada.Substring(0, entrada.Length - 1));
        }
    }


    static void Main()
    {
        Console.WriteLine("Escribe un texto:");
        string texto = Console.ReadLine();

        Console.WriteLine(Reverse(texto));
    }
}
