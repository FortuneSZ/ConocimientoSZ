/*este programa realizara una cuenta atras desde el numero que ponga el usuario
hasta 0,siempre y cuando sea positivo */
using System;
class ejercicio_02c_08
{
	
	static void Main()
	{	
		int numero;
		
		Console.WriteLine("escriba un numero");
		numero = Convert.ToInt32(System.Console.ReadLine());
		
		if (numero>0)
		{
			for (int n=numero;n>=0;n--)
			{
				Console.WriteLine(n);
			}
		}
	}
}
