/*Este programa pide 5 números al usuario,los pone en una pila y los muestra
en orden inverso*/
class Pilas
{
    static void Main()
    {
        int numero;
        Stack<int> pila = new Stack<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Escribe un número");
            numero = Convert.ToInt32(Console.ReadLine());
            pila.Push(numero);
            Console.Clear();
        }
        int[] numeros = pila.ToArray();
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
