/*Este programa básicamente es el juego del ahocado,pide al usuario que
introduzca una palabra,y muestra la silueta de la palabra formada por
guiones,y se irá desvelando conforme el usuario vaya acertando las letras*/
using System.Text;
class Ejercicio_04c_14
{
    static void Main()
    {
        bool resuelto = false;
        int contador = 0, contadorguion = 0, intentos = 8;
        string palabra, intento;
        Console.WriteLine("introduzca una palabra");
        palabra = Console.ReadLine();
        char[] letras = new char[palabra.Length];
        for (int i = 0; i < palabra.Length; i++)
        {
            letras[i] = palabra[i];
        }
        StringBuilder cadena = new StringBuilder(palabra);
        for (int i = 0; i < cadena.Length; i++)
        {
            cadena[i] = '-';
        }
        Console.Clear();
        do
        {
            contadorguion = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                Console.Write(cadena[i]);

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("tienes {0} intentos", intentos);
            Console.WriteLine("diga una letra");
            intento = Console.ReadLine();
            if (intento != palabra)
            {
                intentos--;
            }
            char[] letraint = new char[intento.Length];
            foreach (char letra in intento)
            {
                letraint[contador] = letra;
            }
            for (int i = 0; i < palabra.Length; i++)
            {
                for (int j = 0; j < intento.Length; j++)
                {

                    if (letras[i] == letraint[j])
                    {
                        cadena[i] = letras[i];
                    }
                }
            }
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == '-')
                {
                    contadorguion++;
                }
            }
            if (contadorguion == 0)
            {
                resuelto = true;
            }
        }
        while (intentos > 0 && resuelto == false);
        if (resuelto == true)
        {
            Console.WriteLine("la respuesta es");
            for (int i = 0; i < cadena.Length; i++)
            {
                Console.Write(cadena[i]);
            }
        }
        else
        {
            for (int i = 0; i < cadena.Length; i++)
            {
                Console.Write(cadena[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("fallaste");
        }


    }
}
