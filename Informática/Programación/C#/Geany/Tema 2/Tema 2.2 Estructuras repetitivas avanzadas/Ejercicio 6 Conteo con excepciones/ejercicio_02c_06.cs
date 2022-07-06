/*este programa mostrará por panmtalla todos los numeros del 2 al 106
excepto los multiplos de 10 */
using System;
class ejercicio_02c_06
{
	
	static void Main()
	{	
		for (int n=2; n<=106;n++)
		{
			if (n%10==0)
			{
				continue;
			}
			Console.WriteLine(n);
		}
	}	
}
