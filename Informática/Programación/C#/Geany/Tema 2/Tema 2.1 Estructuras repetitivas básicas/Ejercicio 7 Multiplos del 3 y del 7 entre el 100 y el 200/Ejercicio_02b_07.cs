/*Este programa mostrara los multiplos del 3 y del 7 desde el 100 al 200 */
using System;
class ejercicio_02b_07
{
	
	static void Main()
	{	
		for ( int cont3 =100; cont3<=200 ;cont3=cont3+3)
		{
			Console.WriteLine(cont3);
		}
		Console.WriteLine("fin del 3");
		for (int cont7=100;cont7<=200; cont7=cont7+7)
		{
			Console.WriteLine(cont7+7);
		}
		Console.WriteLine("fin del 7");
	}	
}
