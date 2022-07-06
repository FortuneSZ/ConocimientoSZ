/*Este programa crea una cola,pide al usiario 5 números,los añade a la cola
y posteriormente los muestra*/
class Cola
{
    static void Main()
    {
        int num;
        Queue<int> cola = new Queue<int>();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Escriba un número");
            num = Convert.ToInt32(Console.ReadLine());
            cola.Enqueue(num);
            Console.Clear();
        }
        do
        {
            Console.WriteLine(cola.Dequeue());
        }
        while (cola.Count > 0);
    }
}
