using System;

/*
 * Clase para la pantalla de bienvenida del juego
 */
class Bienvenida
{
    private bool salir;

    public void Lanzar()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        for (int i = 0; i < 5; i++)
            Console.WriteLine();
        Console.WriteLine("****************************************************************************");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("       ░██████╗██████╗░░█████╗░░█████╗░███████╗  ░██████╗██╗░░██╗██╗██████╗░");
        Console.WriteLine("       ██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔════╝  ██╔════╝██║░░██║██║██╔══██╗");
        Console.WriteLine("       ╚█████╗░██████╔╝███████║██║░░╚═╝█████╗░░  ╚█████╗░███████║██║██████╔╝");
        Console.WriteLine("       ░╚═══██╗██╔═══╝░██╔══██║██║░░██╗██╔══╝░░  ░╚═══██╗██╔══██║██║██╔═══╝░");
        Console.WriteLine("       ██████╔╝██║░░░░░██║░░██║╚█████╔╝███████╗  ██████╔╝██║░░██║██║██║░░░░░");
        Console.WriteLine("       ██████╔╝██║░░░░░██║░░██║╚█████╔╝███████╗  ██████╔╝██║░░██║██║██║░░░░░");
        Console.WriteLine("       ╚═════╝░╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚══════╝  ╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░░░░");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("****************************************************************************");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("         ██╗███╗░░██╗██╗░░░██╗░█████╗░██████╗░███████╗██████╗░░██████╗");
        Console.WriteLine("         ██║████╗░██║██║░░░██║██╔══██╗██╔══██╗██╔════╝██╔══██╗██╔════╝");
        Console.WriteLine("         ██║██╔██╗██║╚██╗░██╔╝███████║██║░░██║█████╗░░██████╔╝╚█████╗░");
        Console.WriteLine("         ██║██║╚████║░╚████╔╝░██╔══██║██║░░██║██╔══╝░░██╔══██╗░╚═══██╗");
        Console.WriteLine("         ██║██║░╚███║░░╚██╔╝░░██║░░██║██████╔╝███████╗██║░░██║██████╔╝");
        Console.WriteLine("         ╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░╚══════╝╚═╝░░╚═╝╚═════╝░");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("      Boton 'ESPACIO' para empezar partida     Controles: ↑ ARRIBA");
        Console.WriteLine("      Boton 'ESCAPE' para salir de la partida             ↓ ABAJO");
        Console.WriteLine("                                               DISPARO:  SPACE_BAR");
        Console.ResetColor();

        ConsoleKeyInfo tecla = Console.ReadKey();
        if (tecla.Key == ConsoleKey.Escape)
            salir = true;
        else if (tecla.Key == ConsoleKey.Spacebar)
            salir = false;
        else
        {
            Console.WriteLine("Opción incorrecta. Saliendo del juego");
            salir = true;
        }
    }

    // Obtiene si queremos salir del juego
    public bool GetSalir()
    {
        return salir;
    }
}
