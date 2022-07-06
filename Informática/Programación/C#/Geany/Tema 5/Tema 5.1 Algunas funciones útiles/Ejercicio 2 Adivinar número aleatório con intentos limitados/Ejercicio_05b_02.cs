/*Este programa genera un número aleatório del 1 al 100 y le da al usuario 5
intentos para adivinarlo,tras cada intento en caso de no acertar le dirá al 
usuario si el número es mayor o menor al introducido*/
using System;


class Ejercicio_05b_02
{

    static void Main()
	{
        int numero,numeroadivin,contador=5;
        Random r = new Random();
        numeroadivin=r.Next(1,101);
        do
        {
            Console.WriteLine("escribe tu intento de adivinar el número");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero!=numeroadivin)
            {
                contador--;
                if (numero>numeroadivin)
                {
                    Console.WriteLine("El número introducido es mayor");
                }
                else
                {
                     Console.WriteLine("El número introducido es menor");
                }
            }
        }
        while (contador!=0);
         Console.WriteLine("te quedaste sin intentos");
        
        
      
    }
   
}
