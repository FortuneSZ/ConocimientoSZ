/*Este programa le solicita al usuario el nombre de los invitados,separados por
comas,lo ordena alfabéticamente y posteriormente dicidirlos en los diversos
grupos posibles,si hay,si no se le especificará que no es posible*/
using System;

class Practica_4_3_2
{
	static void Main()
	{
        int div=0,contador=0,salto=0;
        string [] invitados;
        string listainv;
        int [] divisores;
        char [] delimitadores = {','};
        

        Console.WriteLine("Introduzca los nombres de los invitados,separados"
        +"por comas");
        listainv = Console.ReadLine();
        invitados =listainv.Split(delimitadores);
        Console.Clear();
        Console.WriteLine("Lista de invitados");
        Console.WriteLine("");
        for (int i=0;i<invitados.Length;i++)
        {
            Console.Write("{0}",invitados[i]);
            if (i+1<invitados.Length)
            {
                Console.Write(",");
            }
        }
        
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Pulse enter para continuar");
        Console.ReadLine();
        Console.Clear();
        
        Console.WriteLine("Lista de invitados ordenada");
        Console.WriteLine("");
        Array.Sort(invitados);
        for (int i=0;i<invitados.Length;i++)
        {
            Console.Write("{0}",invitados[i]);
            if (i+1<invitados.Length)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Pulse enter para continuar");
        Console.ReadLine();
        Console.Clear();
        for (int i=2;i<invitados.Length;i++)
        {
            if (invitados.Length%i==0)
            {
                div++;
            }
        }
        if (div!=0)
        {
            divisores = new int [div];
            for (int i=1;i<invitados.Length;i++)
            {
                if (invitados.Length%i==0 && i!=1)
                {
                    divisores[contador] =i;
                    contador++;
                }
            }
            
            for (int i=0;i<divisores.Length;i++)
            {
                Console.WriteLine("grupos de {0}",divisores[i]);
                Console.WriteLine("");
                for (int j=0;j<invitados.Length;j++)
                {
                    Console.Write("{0}",invitados[j]);
                    salto++;
                    if (salto%divisores[i]==0)
                    {
                        Console.WriteLine(""); 
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("no se puede dividir en grupos");
        }
	}
}

