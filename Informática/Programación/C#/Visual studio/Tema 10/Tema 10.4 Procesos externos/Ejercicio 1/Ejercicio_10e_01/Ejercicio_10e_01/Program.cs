using System.Diagnostics;

/*
 * Programa con un menú para lanzar distintos
 * procesos externos
 */
ConsoleKeyInfo tecla;

do
{
    Console.Clear();
    Console.WriteLine("1. Notepad");
    Console.WriteLine("2. Calculadora");
    Console.WriteLine("3. Paint");
    Console.WriteLine("4. Salir");
    tecla = Console.ReadKey(true);
    switch(tecla.Key)
    {
        case ConsoleKey.D1:
            Process.Start("notepad.exe");
            break;
        case ConsoleKey.D2:
            Process.Start("calc.exe");
            break;
        case ConsoleKey.D3:
            Process.Start("mspaint.exe");
            break;
    }
}
while (tecla.Key != ConsoleKey.D4);
