/*Este programa pedirá al usuario el número de casos que desea evaluar,para 
luego pedirle 2 palabras,una el nombre y otra el parentesco,si el nombre es
"Luke" y es parentesco es "padre",lo reemplazará por "TOP SECRET"*/
using System;

class YoSoyTu
{
    static void Main ()
    {
        int casos;
        string [,] nombres;
        Console.WriteLine("Escribe el número de casos");
        casos = Convert.ToInt32(Console.ReadLine());
        nombres = new string [casos,2];
        
        for (int i=0;i<casos;i++)
        {
           for (int j=0;j<2;j++)
           {
                if (j==0)
                {
                    Console.WriteLine("Escribe el nombre");
                    nombres[i,j] = Console.ReadLine();
                }
                else
                {
                   Console.WriteLine("Escribe el parentesco");
                    nombres[i,j] = Console.ReadLine(); 
                }
           }
        }
        Console.Clear();
        
        for (int i=0;i<casos;i++)
        {
            if (nombres[i,0]=="Luke" && nombres[i,1]=="padre")
            {
               Console.WriteLine("TOP SECRET");
            }
            else
            {
                Console.WriteLine("{0},yo soy tu {1}",nombres[i,0],
                nombres[i,1]);
            }
        }
    }
}
