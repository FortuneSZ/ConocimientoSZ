class Lista
{
    static void Main()
    {
        string frase, frasebuscar;
        List<string> lista = new List<string>();
        do
        {
            Console.WriteLine("Escriba una frase");
            frase = Console.ReadLine();
            Console.Clear();
            if (frase != "")
            {
                lista.Add(frase);
            }
        }
        while (frase != "");

        Console.WriteLine("Escriba el texto a buscar");
        frasebuscar = Console.ReadLine();
        Console.Clear();

        foreach (string f in lista)
        {
            if (f.Contains(frasebuscar))
            {
                Console.WriteLine(f);
            }
        }
    }
}
