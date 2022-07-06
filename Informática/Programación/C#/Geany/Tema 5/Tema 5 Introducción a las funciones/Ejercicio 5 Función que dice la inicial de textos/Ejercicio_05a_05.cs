/*Este programa crea una función que dice la inicial del texto introducido*/
using System;


class Ejercicio_05a_05
{
    static char Inicial(string texto)
    {
        char resultado = (char)0;
        if (texto.Length >0)
        {
            return texto[0];
        }
        else
        {
            return resultado;
        }
    }
    
    
    static void Main()
	{
        string texto;
         Console.WriteLine("escriba el texto");
       texto =Console.ReadLine();
        Console.WriteLine("la inicial es {0}",Inicial(texto));
    }
   
}
