/*Este programa pedirá al usuario que rellene un array de texto de 10 valores
posteriormente reemplazará en el array toda palabra "java" por "Csharp"*/
class Ejercicio_04c_08
{
    static void Main()
    {
        int contador = 1;
        string[] palabras = new string[10];
        for (int i = 0; i < palabras.Length; i++)
        {
            Console.WriteLine("escriba la {0} palabras", contador);
            palabras[i] = Console.ReadLine();
            contador++;
        }
        Console.Clear();
        for (int i = 0; i < palabras.Length; i++)
        {
            palabras[i] = palabras[i].Replace("Java", "CSharp");

        }
        for (int i = 0; i < palabras.Length; i++)
        {
            Console.WriteLine(palabras[i]);
        }

    }

}
