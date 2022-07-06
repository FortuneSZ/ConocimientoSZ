/*
 * Programa que le pide una frase al usuario y la muestra codificada 
 * incrementando en uno las letras alfabéticas (la 'z' pasa a 'a')
 * Usamos StringBuilder
 */
using System.Text;

class Repaso2_4b
{
    static void Main()
    {
        string frase;
        StringBuilder fraseModificable;

        Console.WriteLine("Escribe una frase:");
        frase = Console.ReadLine();
        fraseModificable = new StringBuilder(frase);

        for (int i = 0; i < fraseModificable.Length; i++)
        {
            if ((fraseModificable[i] >= 'a' && fraseModificable[i] < 'z') ||
                (fraseModificable[i] >= 'A' && fraseModificable[i] < 'Z'))
            {
                fraseModificable[i]++;
            }
            else if (fraseModificable[i] == 'z')
            {
                fraseModificable[i] = 'a';
            }
            else if (fraseModificable[i] == 'Z')
            {
                fraseModificable[i] = 'A';
            }
        }

        Console.WriteLine(fraseModificable.ToString());
    }
}
