/*Este programa pide al usuario frases, hasta que ponga una cadena vacía
 ,añadiendolas a una cola y luego mostrando las frases almacenadas*/
class Frases
{
    static void Main()
    {
        string frase;
        Queue<string> cola = new Queue<string>();
        do
        {
            Console.WriteLine("Escriba una frase");
            frase = Console.ReadLine();
            Console.Clear();
            if (frase != "")
            {
                cola.Enqueue(frase);
            }
        }
        while (frase != "");

        do
        {
            Console.WriteLine(cola.Dequeue());
        }
        while (cola.Count > 0);
    }
}
