/*Este programa crea una función que dice si el número introducido por el
usuario si es primo o no*/

class Ejercicio_05a_07
{
    static bool primo(int numero)
    {
        int n = 2;
        bool esPrimo = true;
        while (esPrimo && n <= numero / 2)
        {
            if (numero % n == 0)
            {
                esPrimo = false;
            }
            n++;
        }

        if (esPrimo && numero > 1)
        {
            Console.WriteLine("Es primo");
        }
        else
        {
            Console.WriteLine("No es primo");
        }
        return esPrimo;
    }

    static void Main()
    {
        int numero;
        Console.WriteLine("escribe un número");
        numero = Convert.ToInt32(Console.ReadLine());
        primo(numero);
    }

}
