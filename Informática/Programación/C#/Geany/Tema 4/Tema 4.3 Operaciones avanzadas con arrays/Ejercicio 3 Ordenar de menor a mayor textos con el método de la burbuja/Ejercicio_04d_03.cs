/*Este programa pide al usuario 10 palabras y las ordena de menor a mayor*/
using System;
using System.Text;
class Ejercicio_04d_03
{	
	static void Main()
	{
		int contador=1;
		string [] textos = new string [10];
		for (int i = 0; i < textos.Length;i++)
		{
			Console.WriteLine("escriba la {0} palabra",contador);
			textos[i] = Console.ReadLine();
			contador++;
		}
		
		for (int i = 0; i < textos.Length-1; i++)
		{
			for (int j = i+1; j < textos.Length; j++)
			{
				if (textos[i].CompareTo(textos[j])>0)
				{
					string auxiliar = textos[i];
					textos[i] = textos[j];
					textos[j] = auxiliar;
				}
			}
		}
		Console.Clear();
		for (int i=0;i< textos.Length;i++)
		{
			Console.Write(textos[i]+" ");
		}
	}
}

