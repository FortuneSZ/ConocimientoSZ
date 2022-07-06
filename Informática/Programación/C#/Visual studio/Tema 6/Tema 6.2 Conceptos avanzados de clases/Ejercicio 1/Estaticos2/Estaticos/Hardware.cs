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

    public static void EscribirCentrado(string texto)
    {
        int y = Console.WindowHeight / 2 - 1;
        int x = Console.WindowWidth / 2 - texto.Length / 2;
        Console.SetCursorPosition(x, y);
        Console.Write(texto);
    }

    public void EscribirCentrado2(string texto)
    {
        int y = Console.WindowHeight / 2 + 1;
        int x = Console.WindowWidth / 2 - texto.Length / 2;
        Console.SetCursorPosition(x, y);
        Console.Write(texto);
    }
}
