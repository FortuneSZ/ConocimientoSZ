//Clase Hardware
class Hardware
{
    public static void BorrarPantalla()
    {
        for (byte i = 0; i < 25; i++)
            Console.WriteLine();
    }

    public static void UnMetodo()
    {
        Console.WriteLine("Pulsa Intro para borrar");
        Console.ReadLine();
        BorrarPantalla();   // Misma clase, no hace falta "Hardware."         
        Console.WriteLine("Borrado!");
    }
    public static void EscribirCentradoS(string texto)
    {
        Console.Write(new string(' ', (Console.WindowWidth - texto.Length) / 2));
        Console.WriteLine(texto);
    }
    public void EscribirCentrado(string texto)
    {
        Console.Write(new string(' ', (Console.WindowWidth - texto.Length) / 2));
        Console.WriteLine(texto);
    }
}
