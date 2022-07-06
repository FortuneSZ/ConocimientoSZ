using System;
using System.Threading;
//Clase para la pantalla de bienvenida del juego
class Bienvenida
{
    private bool salir;
    public void Lanzar()
    {
        Console.ForegroundColor = (ConsoleColor)Configuracion.r.Next(1, 16);
        for (int i = 0; i < 5; i++)
            Console.WriteLine();

        Console.Title = "ASCII Art";
        string title = @"
                #     #        #     #                      
                #     # #    # #     #                      
                #     # #    # #     #                      
                #     # #    # #     #                      
                #     # # ## # #     #                      
                #     # ##  ## #     #                      
                 #####  #    #  #####                       
                                                            
          #####                                                     
         #     # #####    ##    ####  ######  ####  #    # # #####  
         #       #    #  #  #  #    # #      #      #    # # #    # 
          #####  #    # #    # #      #####   ####  ###### # #    # 
               # #####  ###### #      #           # #    # # #####  
         #     # #      #    # #    # #      #    # #    # # #      
          #####  #      #    #  ####  ######  ####  #    # # #      
                                                                    ";
        Console.WriteLine(title);
        Console.WriteLine();
        Console.ForegroundColor = (ConsoleColor)Configuracion.r.Next(1, 16);
        Console.WriteLine("*************************************************");
        Console.ForegroundColor = (ConsoleColor)Configuracion.r.Next(1, 16);
        Console.WriteLine("Bienvenido a UwU Spaceship!!!");
        Console.WriteLine("Controles: ");
        Console.WriteLine("Movimiento : WASD o Flechas");
        Console.WriteLine("Disparo : Barra espaciadora");
        Console.WriteLine("Pausar/Continuar : Q");
        Console.WriteLine("Pulse la barra espaciadora para jugar o Esc para salir");
        Console.ForegroundColor = (ConsoleColor)Configuracion.r.Next(1, 16);
        Console.WriteLine("*************************************************");
        Thread.Sleep(200);
        Console.ResetColor();
        ConsoleKeyInfo tecla = Console.ReadKey();
        if (tecla.Key == ConsoleKey.Escape)
            salir = true;
        else if (tecla.Key==ConsoleKey.Spacebar)
            salir = false;
        else
        {
            Console.WriteLine("Opción incorrecta. Saliendo del juego");
            salir = true;
        }
    }
    public bool GetSalir()
    {
        return salir;
    }
}
