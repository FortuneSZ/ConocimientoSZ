/*Este programa pide al usuario que introduzca el nombre de 10 ganadores de
Wimbledon,el programa los añadirá a un conjunto y los mostrará por pantalla*/
class Wimbledon
{
    static void Main()
    {
        string nombre;
        HashSet<string> set = new HashSet<string>();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Escribe el nombre de un ganador");
            nombre = Console.ReadLine();
            Console.Clear();
            set.Add(nombre);
        }

        foreach (string nom in set)
        {
            Console.WriteLine(nom);
        }
    }
}
