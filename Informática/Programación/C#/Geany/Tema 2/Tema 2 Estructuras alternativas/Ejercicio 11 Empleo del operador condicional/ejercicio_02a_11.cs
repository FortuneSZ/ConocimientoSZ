/* vamos a crear un programa que empleando el operador condicional nos diga
que numero es menor*/
using System;
class ejercicio_02a_11
{
	
	static void Main()
	{	
		int numero1,numero2,numeromenor;
		
		Console.WriteLine("dime 2 numeros");
		numero1=Convert.ToInt32(System.Console.ReadLine());
		numero2=Convert.ToInt32(System.Console.ReadLine());
		
		numeromenor = numero1 <= numero2 ? numero1 : numero2;
		Console.WriteLine("{0} es el menor numero",numeromenor);
	}	
}
