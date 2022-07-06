/*Este programa le pedirá al usuario su contraseña,las veces que haga falta
hasta que la acierte*/
using System;
class ejercicio_02b_03
{
	
	static void Main()
	{	
		int contraseña;
		
		Console.WriteLine("escriba su contraseña");
		contraseña = Convert.ToInt32(System.Console.ReadLine());
		
		do 
		{
			Console.WriteLine("contraseña incorrecta");
			Console.WriteLine("escriba su contraseña");
			contraseña = Convert.ToInt32(System.Console.ReadLine());
		}
		
		while (contraseña!=1111 );
		
		Console.WriteLine("contraseña correcta");
	
	}	
}
