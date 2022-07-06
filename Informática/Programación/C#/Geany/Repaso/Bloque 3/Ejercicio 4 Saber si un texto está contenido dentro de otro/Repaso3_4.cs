/* 
 * Programa que define una función que indica si un texto está
 * contenido dentro de otro
 */ 
 
using System;

class Repaso3_4
{		
	static bool MensajeSecreto(string t1, string t2)
	{
		int i1 = 0, i2 = 0;
		bool resultado;
		
		while(i1 < t1.Length && i2 < t2.Length)
		{
			if(t2[i2] == ' ')
			{
				i2++;
			}
			else if (t2[i2] == t1[i1])
			{
				i2++;
				i1++;
			}
			else
			{
				while(i1 < t1.Length && t2[i2] != t1[i1])
				{
					i1++;
				}
			}
		}
		
		if (i2 >= t2.Length)
		{
			resultado = true;
		}
		else
		{
			resultado = false;
		}
		
		return resultado;
	}
	
    static void Main()
    {
		Console.WriteLine(MensajeSecreto(
			"había una vez un circo que alegraba siempre el corazón.", 
			"wewewe"));
    }
}
