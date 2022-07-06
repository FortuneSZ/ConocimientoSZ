/*este programa solicitara al usuario 2 numeros,y realizara un conteo desde
el primero al segundo*/
using System;
class practica_2_2_2
{
	static void Main()
	{	
		int numero1,numero2;
		
		Console.WriteLine("introduce el primer numero");
		numero1 = Convert.ToInt32(System.Console.ReadLine());
		
		Console.WriteLine("introduce el segundo numero");
		numero2 = Convert.ToInt32(System.Console.ReadLine());	
		
		if (numero1<numero2)
		{
			for (int y=numero1;y<=numero2;y++)
			{
				Console.WriteLine("{0}",y);
			}
		}
		else
		{
			for (int x=numero1;x>=numero2;x--)
			{
				Console.WriteLine("{0}",x);
			}
		}
	}
}
