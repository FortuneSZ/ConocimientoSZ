/*Este programa pide al usuario que introduzca una frase,esta solo contará
hasta el caracter número 60,a partir de ahí se cortará,luego de eso se
compararán las palabras de la frase introducida con las de un array predefinido
y si se encuentran en el se mostrarán en rojo,si no se mostrarán del color
predeterminado,todo el mensaje se mostrará centrado en la consola*/

class Corrector
{
    static string limite(ref string frase)
    {
        int contador = 0;
        foreach (char caract in frase)
        {
            contador++;
        }
        if (contador > 60)
        {
            frase = frase.Remove(60, contador - 60);
        }
        return frase;
    }

    static void mostrarpalabras(string[] fragmentos, string[] palabras)
    {
        Console.SetCursorPosition(Console.WindowWidth / 2, 10);
        for (int i = 0; i < fragmentos.Length; i++)
        {
            for (int j = 0; j < palabras.Length; j++)
            {
                if (fragmentos[i].ToUpper().CompareTo(palabras[j].ToUpper()) == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
            }
            Console.Write(fragmentos[i] + " ");
            Console.ResetColor();
        }
    }
    static void Main()
    {
        char[] delimitadores = { ',', ' ' };
        string frase;
        string[] fragmentos;
        string[] palabras = new string[5] { "no", "si", "te", "puede", "yo" };
        Console.WriteLine("Escribe una frase");
        frase = Console.ReadLine();
        limite(ref frase);
        fragmentos = frase.Split(delimitadores);
        mostrarpalabras(fragmentos, palabras);
    }
}

