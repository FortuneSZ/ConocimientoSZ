/*Este programa emplea 2 funciones,una que te dice si el número introducido
tiene todos sus dígitos en orden ascendente o no,y otra que en base a la palabra
introducida,invierte mayúsculas por minúsculas y vicebersa,ambas son probadas
con 3 casos distintos desde el main*/

class Recursividad
{
    static bool DigitosAscendentes(int numero, int DigAnterior)
    {
        if (numero % 10 > DigAnterior)
        {
            return false;
        }
        if (numero > 0)
        {
            return DigitosAscendentes(numero / 10, numero % 10);
        }
        return true;
    }

    static String TransformarTexto(string texto, string transformado)
    {
        if (texto.Length > 0)
        {
            if (texto[0] >= 'a')
            {
                transformado += texto.ToUpper()[0];
                return TransformarTexto(texto.Substring
                (1), transformado);
            }
            else
            {
                transformado += texto.ToLower()[0];
                return TransformarTexto(texto.Substring
                (1), transformado);
            }
        }
        return transformado;
    }
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^*^*^*^*^*^*^*^*^*^*^*^*");
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Digitos ascendentes");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^");
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Primer número: 12345");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^");
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(DigitosAscendentes(12345, 9));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^");
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Segundo número: 54321");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^");
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(DigitosAscendentes(54321, 9));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^");
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Tercer número: 147852");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^");
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(DigitosAscendentes(147852, 9));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^");
        Console.WriteLine("^*^*^*^*^*^*^*^*^*^*^*^*");

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("^*^*^*^*^*^*^*^*^*^*^*^*^*^*");
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Transformar texto");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^");
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Primer texto: Hola,Buenas");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^");
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(TransformarTexto("Hola,Buenas", ""));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^");
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Segundo texto: Se QuE nO");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^");
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(TransformarTexto("Se QuE nO", ""));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^");
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Tercer texto: SE QUE SI");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^");
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(TransformarTexto("SE QUE SI", ""));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("^*^*^*^*^*^*^*^*^*^*^*^*^*^*");
        Console.ResetColor();
    }
}
