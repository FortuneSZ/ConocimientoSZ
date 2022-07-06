/*Este programa crea una función que en base a 2 parámetros de fecha mínima
y máxima,le pide al usuario que diga una fecha de nacimiento válida,
* repitiendolo hasta que la introduzca*/
using System;


class Ejercicio_05a_06
{
    static int pedirentero(int n1,int n2)
    {
        int edad=0;
        do
        {
            try
            {
                Console.WriteLine("introduzca su edad");
                edad = Convert.ToInt32(Console.ReadLine());
            }
            catch ( Exception)
            {
                Console.WriteLine("número incorrecto");
            }
        }
        while(edad<n1 || edad>n2);
        Console.Clear();
        return edad;
            
        
    }

    static void Main()
	{
       int min,max,edad;
       Console.WriteLine("dime un año mínimo");
       min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("dime un año máximo");
       max = Convert.ToInt32(Console.ReadLine());
       edad=pedirentero(min,max);
       Console.WriteLine("su año de nacimiento es {0}",edad);
    }
   
}
