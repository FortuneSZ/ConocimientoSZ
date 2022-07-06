/* Programa que pida un texto y lo muestre codificado o encriptado. Para 
 * encriptarlo, sustituiremos cada letra por su letra siguiente, dejando como
 * estan los caracteres que no sean letras. En caso de que la letra sea la Z, 
 * llevara a la letra A. */

using System.Text;

class Repaso2_4
{
    static void Main()
    {
        string frase;
        StringBuilder fraseModificable;

        Console.WriteLine("Dime la frase:");
        frase = Console.ReadLine();
        fraseModificable = new StringBuilder(frase);

        for (int i = 0; i < frase.Length; i++)
        {
            fraseModificable[i] = frase[i];
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
        Console.Write(fraseModificable.ToString());
        Console.WriteLine();
        Console.WriteLine(frase);
    }
}
