/*Este programa pide al usuario una frase,y muestra sus palabras en orden
inverso*/
class Ejercicio_04c_010
{
    static void Main()
    {
        string frase;
        char[] delimitadores = { ',', ' ' };
        Console.WriteLine("Introduce una frase: ");
        frase = Console.ReadLine();
        string[] partes = frase.Split(delimitadores);
        Console.WriteLine("Frase insertada : {0}", frase);
        Console.Write("Frase resultado : ");
        for (int i = partes.Length; i > 0; i--)
        {
            Console.Write("{0}", partes[i - 1]);
            if (i - 1 > 0)
                Console.Write(" ");
        }
    }
}
