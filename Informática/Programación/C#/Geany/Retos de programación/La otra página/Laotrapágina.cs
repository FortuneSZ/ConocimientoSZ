using System;

class laotrapagina
{
	static void Main()
	{
        int número,veces;
        Console.WriteLine("escribe el número de casos");
        veces = Convert.ToInt32(Console.ReadLine());
        
        for (int i=0;i<veces;i++)
        {
            Console.WriteLine("escribe un número del 2 al 1000");
            número = Convert.ToInt32(Console.ReadLine());
            
            if (número % 2 == 0)
            {
                Console.WriteLine(número+1);
            }
            else
            {
                Console.WriteLine(número-1);
            }
        }
        
        
    }
}
