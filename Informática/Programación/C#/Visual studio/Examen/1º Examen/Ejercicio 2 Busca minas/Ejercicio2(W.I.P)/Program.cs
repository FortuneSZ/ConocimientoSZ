class Ejercicio2
{
    static void instrucciones()
    {
        Console.WriteLine("Instrucciones");
        Console.WriteLine("");
        Console.WriteLine("Un asterisco * representará un muro del mapa");
        Console.WriteLine("Una B representará una bomba");
        Console.WriteLine("Un guión - representará un espacio vacío");
        Console.WriteLine("Una P representará una persona");
        Console.WriteLine("");
    }

    static void settamaño(ref int tamaño, ref int longlin)
    {
        Console.WriteLine("escriba el tamaño");
        tamaño = Convert.ToInt32(Console.ReadLine());
        string[] mapatemp = new string[tamaño];


        for (int i = 0; i < tamaño; i++)
        {
            Console.WriteLine("introduce la {0} linea", i + 1);
            mapatemp[i] = Console.ReadLine();
            if (longlin == 0)
            {
                foreach (char caracter in mapatemp[i])
                {
                    longlin++;
                }
            }
        }
        Console.Clear();
        mostrarmapa(mapatemp, tamaño);
        analizmapa(mapatemp, tamaño, longlin);
    }

    static void mostrarmapa(string[] mapatemp, int tamaño)
    {
        for (int i = 0; i < tamaño; i++)
        {
            Console.WriteLine(mapatemp[i]);
        }
    }

    static void analizmapa(string[] mapatemp, int tamaño, int longlin)
    {
        int j = 0, contbomb = 0, persjuntbomb = 0;
        char[,] mapa = new char[tamaño, longlin];

        for (int i = 0; i < tamaño; i++)
        {
            foreach (char caracterr in mapatemp[i])
            {
                mapa[i, j] = caracterr;
                if (mapa[i, j] == 'B')
                {
                    contbomb++;
                }
                j++;
            }
            j = 0;
        }
        Console.WriteLine("");
        if (contbomb != 0)
        {
            Console.WriteLine("hay {0} bombas", contbomb);
        }
        else
        {
            Console.WriteLine("No hay bombas");
        }
        Console.WriteLine("");
        if (persjuntbomb != 0)
        {
            Console.WriteLine("hay {0} personas junto a bombas", contbomb);
        }
        else
        {
            Console.WriteLine("No hay personas junto a bombas");
        }
    }

    static void Main()
    {
        int tamaño = 0, longlin = 0;
        instrucciones();
        settamaño(ref tamaño, ref longlin);
    }
}
