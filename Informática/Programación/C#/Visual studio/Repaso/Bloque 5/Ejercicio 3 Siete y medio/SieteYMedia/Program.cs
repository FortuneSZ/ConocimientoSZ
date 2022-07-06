using System;
using System.Collections.Generic;

enum Palo { OROS, COPAS, ESPADAS, BASTOS }

enum Simbolo { UNO, DOS, TRES, CUATRO, 
    CINCO, SEIS, SIETE, SOTA, CABALLO, REY }

class Program
{
    static Random random = new Random();

    static List<Carta> CrearMazo()
    {
        List<Carta> mazo = new List<Carta> ();

        foreach(Palo p in Enum.GetValues(typeof(Palo)))
        {
            foreach(Simbolo s in Enum.GetValues (typeof(Simbolo)))
            {
                Carta c = new Carta(p, s);
                mazo.Add(c);
            }
        }

        return mazo;
    }

    static void Barajar(List<Carta> mazo)
    {
        for(int i = 0; i < mazo.Count; i++)
        {
            int aleatorio = random.Next(0, mazo.Count);
            Carta aux = mazo[i];
            mazo[i] = mazo[aleatorio];
            mazo[aleatorio] = aux;
        }
    }

    static void Main()
    {
        string respuesta;
        float total = 0;
        List<Carta> mazo = CrearMazo();
        Barajar(mazo);
        do
        {
            Console.WriteLine("¿Quieres una carta?(S/N)");
            respuesta = Console.ReadLine();
            if (respuesta == "S")
            {
                Carta actual = mazo[0];
                mazo.RemoveAt(0);
                Console.WriteLine(actual);
                total += actual.ValorCarta();
                Console.WriteLine("Puntos: {0}", total);
            }
        }
        while (respuesta == "S" && total <= 7.5f);

        Console.WriteLine("Puntuación final: {0}", total);
        if (total > 7.5f)
            Console.WriteLine("Has perdido");
    }
}