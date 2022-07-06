/*este programa contara el numero de aes en la palabra que el usuario
escriba */
using System;
class ejercicio_02c_07
{

	static void Main()
	{
		int numeroa = 0;

		Console.WriteLine("escribe un texto");
		string nombre = Console.ReadLine();

		foreach (char letra in nombre)
		{
			if (letra == 'a')
			{
				numeroa++;
			}
		}
		Console.WriteLine("el texto tiene {0} aes", numeroa);
	}
}
