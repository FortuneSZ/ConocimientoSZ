/*Este programa empleará un array ya definido,que,introducido en una función,
sin variar su orden o valores,calculará su media,su moda y su mediana*/

class Practica_5_1_2
{

    static void CalcularEstadisticas
    (int[] numeros, out int mediana, out int moda, out int media)
    {
        int summedia = 0;
        int[] numeros2 = new int[numeros.Length];
        int[] contador = new int[numeros2.Length];
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros2[i] = numeros[i];
        }
        Array.Sort(numeros2);

        foreach (int numero in numeros2)
        {
            summedia = summedia + numero;
        }
        media = summedia / numeros2.Length;

        mediana = numeros2[numeros2.Length / 2];

        moda = 0;
        for (int i = 0; i < numeros2.Length; i++)
        {
            for (int j = 0; j < numeros2.Length; j++)
            {
                if (numeros2[i] == numeros2[j])
                {
                    contador[i]++;
                }
                for (int x = 0; x < numeros2.Length; x++)
                {
                    if (moda == 0)
                    {
                        moda = numeros2[0];
                    }
                    if (contador[i] > moda)
                    {
                        moda = numeros2[i];
                    }
                }
            }

        }
    }



    static void Main()
    {
        int mediana, moda, media;
        int[] numeros = new int[] { 3, 8, 6, 17, 4, 2, 9, 3, 10, 12,
            9, 3, 2, 10};

        Console.WriteLine("el array es ");
        Console.Write("");
        Console.WriteLine("");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("{0} ", numeros[i]);
        }
        Console.WriteLine("");
        Console.WriteLine("");

        CalcularEstadisticas(numeros, out mediana, out moda, out media);
        Console.WriteLine("la media es {0}", media);
        Console.WriteLine("la moda es {0}", moda);
        Console.WriteLine("la mediana es {0}", mediana);
    }
}
