/* */

using System;

class La_Prueba_de_las_Cajas_y_las_bolas
{
    static int dividir(int cajas)
    {
        if (cajas == 1)
        {
            return 1;
        }
        else
            return 1 + dividir(cajas / 2);
    }
    
    static void Main()
    {
        int cajas, viajes;
        
        while(true)
        {
            cajas = Convert.ToInt32(Console.ReadLine());
            viajes= dividir(cajas);
            Console.WriteLine(viajes);
        }
    }
}
