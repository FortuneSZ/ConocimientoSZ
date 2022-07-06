/*Este programa registrará 5 notas desde el cmd,descargará la máxima y la mínima
y dará la media de las otras 3,con dos cifras decimales,si hay más o menos de 5
valores o los valores son mayores a 10 o inferiores o iguales a 0 dirá que son
incorrectos*/
class SaltoTrampolin
{
    static bool validar(int[] notas)
    {
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] < 0 || notas[i] > 10)
            {
                return false;
            }
        }
        return true;
    }

    static int[] NotMinMax(int[] notas)
    {
        Array.Sort(notas);
        int[] NotasFiltradas = new int[] { notas[1], notas[2], notas[3] };
        return NotasFiltradas;
    }

    static string media(int[] notasFiltradas)
    {
        float resultado = 0;
        for (int i = 0; i < notasFiltradas.Length; i++)
        {
            resultado += notasFiltradas[i];
        }
        resultado /= 3;
        return resultado.ToString("N2");
    }

    static void Main(string[] args)
    {
        int[] notas = new int[5];
        int[] notasFiltradas;
        if (args.Length == 5)
        {
            for (int i = 0; i < args.Length; i++)
            {
                notas[i] = Convert.ToInt32(args[i]);
            }

            if (validar(notas) == true)
            {
                notasFiltradas = NotMinMax(notas);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Nota final " + media(notasFiltradas));
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Notas incorrectas");
                Console.ResetColor();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Notas incorrectas");
            Console.ResetColor();
        }
    }
}

