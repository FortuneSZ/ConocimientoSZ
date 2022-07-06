/* Programa que genere aleatoriamente 6 numeros (del 1 al 49). El programa
 * dira cuantos intentos ha acertado en total*/

class Ejercicio_05b_03
{

    static Random r = new Random();

    static int[] GenerarLoteria()
    {
        int[] numeros = new int[6];
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = r.Next(1, 50);
        }
        Array.Sort(numeros);

        return numeros;
    }
    static bool HayRepetidos(int[] numeros)
    {
        bool resultado = false;
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[i] == numeros[j])
                {
                    resultado = true;
                }
            }
        }
        return resultado;
    }
    static int[] LeerCombinacion()
    {
        int[] numeros = new int[6];

        Console.WriteLine("Escribe 6 numeros");
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }
        return numeros;
    }
    static int ComprobarAciertos(int[] usuario, int[] ganadora)
    {
        int acierto = 0;
        for (int i = 0; i < usuario.Length; i++)
        {
            for (int j = 0; j < ganadora.Length; j++)
            {
                if (usuario[i] == ganadora[j])
                {
                    acierto++;
                }
            }
        }
        return acierto;
    }
    static void Main()
    {
        int[] combinacionGanadora;
        int[] combinacionUsuario;
        int aciertos;
        do
        {
            combinacionGanadora = GenerarLoteria();
        }
        while (HayRepetidos(combinacionGanadora));

        combinacionUsuario = LeerCombinacion();
        aciertos = ComprobarAciertos(combinacionUsuario, combinacionGanadora);

        Console.WriteLine("tienes {0} aciertos", aciertos);
        Console.WriteLine("Combinacion ganadora");

        foreach (int numero in combinacionGanadora)
        {
            Console.Write("{0} ", numero);
        }
    }
}
