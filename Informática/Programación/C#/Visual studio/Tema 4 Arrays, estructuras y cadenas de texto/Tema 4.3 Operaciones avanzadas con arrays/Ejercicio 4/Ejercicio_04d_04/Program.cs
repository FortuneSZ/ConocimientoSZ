/*Este programa ordena de menor a mayor los textos introducidos por el
usiario empleando Array.Sort*/
class Ejercicio_04d_04
{
    static void Main()
    {
        int contador = 1;
        string[] textos = new string[10];
        for (int i = 0; i < textos.Length; i++)
        {
            Console.WriteLine("escriba la {0} palabra", contador);
            textos[i] = Console.ReadLine();
            contador++;
        }

        Array.Sort(textos);
        Console.Clear();
        for (int i = 0; i < textos.Length; i++)
        {
            Console.Write(textos[i] + " ");
        }
    }
}
