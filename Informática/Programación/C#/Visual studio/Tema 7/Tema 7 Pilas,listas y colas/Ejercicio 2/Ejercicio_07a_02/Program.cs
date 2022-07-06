/*
 * Programa que resuelve una expresión matemática
 * expresada en notación polaca inversa usando
 * una pila
 */
class Program
{
    static bool RealizarOperacion(Stack<int> numeros,
        string operador)
    {
        bool correcto = true;

        if (numeros.Count >= 2)
        {
            int num1 = numeros.Pop();
            int num2 = numeros.Pop();
            switch (operador)
            {
                case "+":
                    numeros.Push(num2 + num1);
                    break;
                case "-":
                    numeros.Push(num2 - num1);
                    break;
                case "*":
                    numeros.Push(num2 * num1);
                    break;
                case "/":
                    numeros.Push(num2 / num1);
                    break;
                default:
                    correcto = false;
                    break;
            }
        }
        else
        {
            correcto = false;
        }

        return correcto;
    }

    static void Main()
    {
        Stack<int> numeros = new Stack<int>();
        int i, numero;
        string expresion;
        string[] partes;
        bool correcto = true;

        Console.WriteLine("Escribe la expresión matemática:");
        expresion = Console.ReadLine();
        partes = expresion.Split(' ');

        i = 0;
        while (i < partes.Length && correcto)
        {
            if (Int32.TryParse(partes[i], out numero))
            {
                numeros.Push(numero);
            }
            else
            {
                correcto = RealizarOperacion(numeros, partes[i]);
            }
            i++;
        }

        if (numeros.Count == 1 && correcto)
        {
            Console.WriteLine("Resultado: {0}",
                numeros.Pop());
        }
        else
        {
            Console.WriteLine("Expresión incorrecta");
        }
    }
}