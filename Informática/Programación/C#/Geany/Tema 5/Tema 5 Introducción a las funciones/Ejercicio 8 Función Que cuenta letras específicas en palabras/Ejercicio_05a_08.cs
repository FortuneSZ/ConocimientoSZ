/*Este programa crea una función que cuenta el número de veces que una letra
específica (introducida por el usuario) en una palabra introducida por el 
usuario*/
using System;


class Ejercicio_05a_08
{
    static int contarletra(char letra,string texto)
    {
       int contadorletra=0;
       foreach (char letraa in texto) 
       {
           if(letra==letraa)
           {
            contadorletra++;
           }
       }
       return contadorletra;
    }

    static void Main()
	{
       char letra;
       string texto;
       Console.WriteLine("escribe un texto");
      texto = Console.ReadLine();
      Console.WriteLine("escribe la letra que quiere contar");
      letra =Convert.ToChar(Console.ReadLine());
      
      Console.WriteLine("hay {0} {1} en el texto",
      contarletra(letra,texto),letra);
    }
   
}
