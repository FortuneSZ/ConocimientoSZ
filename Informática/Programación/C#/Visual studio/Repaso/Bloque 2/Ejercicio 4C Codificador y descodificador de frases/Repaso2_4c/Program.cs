/*
 * Programa que le pide una frase al usuario y la muestra codificada 
 * incrementando en uno las letras alfabéticas (la 'z' pasa a 'a')
 * Usamos StringBuilder
 * Tras codificar, le preguntamos al usuario y si quiere descodificar y, 
 * si es así, aplicamos el proceso inverso
 */
using System.Text;

class Repaso2_4c
{
    static void Main()
    {
        StringBuilder fraseModificable;
        char respuesta;

        Console.WriteLine("Escribe una frase:");
        fraseModificable = new StringBuilder(Console.ReadLine());

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

        Console.WriteLine("Quieres volver a descodificarla?(S/N)");
        respuesta = Convert.ToChar(Console.ReadLine());

        if (respuesta == 's' || respuesta == 'S')
        {
            for (int i = 0; i < fraseModificable.Length; i++)
            {
                if ((fraseModificable[i] >= 'b' && fraseModificable[i] <= 'z') ||
                    (fraseModificable[i] >= 'B' && fraseModificable[i] <= 'Z'))
                {
                    fraseModificable[i]--;
                }
                else if (fraseModificable[i] == 'a')
                {
                    fraseModificable[i] = 'z';
                }
                else if (fraseModificable[i] == 'A')
                {
                    fraseModificable[i] = 'Z';
                }
            }

            Console.WriteLine(fraseModificable.ToString());

        }
    }
}
