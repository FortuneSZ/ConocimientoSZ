/*Programa que de una secuencia de números saca
 * cuales son diferentes, cuales es el número máximo 
 * número de calcetines sueltos*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string secuencia;
        string[] partes;
        int maxSin = 0, resultado = 0;
        HashSet<string> total = new HashSet<string>();
        HashSet<string> distintos = new HashSet<string>();
        Console.WriteLine("Secuencia: ");
        secuencia = Console.ReadLine();
        partes = secuencia.Split(' ');
        foreach(string p in partes)
        {
            total.Add(p);
        }
        for(int i = 0; i < partes.Length; i++)
        {
            if(distintos.Contains(partes[i]))
            {
                maxSin--;
                distintos.Remove(partes[i]);
            }
            else
            {
                distintos.Add(partes[i]);
                maxSin++;
            }
            if(maxSin > resultado)
                resultado = maxSin;
        }
        Console.WriteLine("Hay un total de " +
            total.Count + " distintos");
        Console.WriteLine("El número máximo de calcetines sin emparejar" +
            " que ha habido es de {0}", resultado);
    }
}

