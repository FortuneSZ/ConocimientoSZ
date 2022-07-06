/* 
 * Programa que define una función recursiva que determina si
 * un texto es palíndromo o no
 */

class Ejercicio_05c_05
{
    static bool Palindromo(string texto)
    {
        if (texto.Length <= 1)
        {
            return true;
        }
        else
        {
            return texto[0] == texto[texto.Length - 1] &&
                   Palindromo(texto.Substring(1, texto.Length - 2));
        }
    }

    static void Main()
    {
        string texto;

        Console.WriteLine("Escribe un texto:");
        texto = Console.ReadLine();

        texto = texto.ToLower().Replace(" ", "");

        if (Palindromo(texto))
        {
            Console.WriteLine("Es palíndromo");
        }
        else
        {
            Console.WriteLine("No es palíndromo");
        }
    }
}
