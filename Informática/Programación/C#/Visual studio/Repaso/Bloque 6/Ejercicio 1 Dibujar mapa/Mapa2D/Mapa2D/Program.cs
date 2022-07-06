using System;
using System.IO;

/*
 * Programa para leer y manipular un mapa en 2 dimensiones
 */ 
class Program
{
    const string FICHERO = "mapa.txt";

    static char[,] LeerMapa(string fichero)
    {
        char[,] mapa;

        string[] lineas = File.ReadAllLines(fichero);
        mapa = new char[lineas.Length, lineas[0].Length];

        for (int i = 0; i < lineas.Length; i++)
        {
            for (int j = 0; j < lineas[i].Length; j++)
            {
                mapa[i, j] = lineas[i][j];
            }
        }

        return mapa;
    }

    static void DibujarMapa(char[,] mapa)
    {
        Console.Clear();
        for(int i = 0; i < mapa.GetLength(0); i++)
        {
            for(int j = 0; j < mapa.GetLength(1); j++)
            {
                switch(mapa[i, j])
                {
                    case '#':
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 'P':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 'S':
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                Console.Write(mapa[i, j]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }

    static void Posicion(char[,] mapa, out int x, out int y)
    {
        x = -1;
        y = -1;

        for(int i = 0; i < mapa.GetLength(0); i++)
        {
            for (int j = 0; j < mapa.GetLength(1); j++)
            {
                if(mapa[i, j] == 'P')
                {
                    x = j;
                    y = i;
                }
            }
        }
    }

    static void Main()
    {
        int x, y;
        char[,] mapa = LeerMapa(FICHERO);
        DibujarMapa(mapa);
        Posicion(mapa, out x, out y);
        Console.WriteLine("Personaje en X = {0}, y = {1}", x, y);
    }
}