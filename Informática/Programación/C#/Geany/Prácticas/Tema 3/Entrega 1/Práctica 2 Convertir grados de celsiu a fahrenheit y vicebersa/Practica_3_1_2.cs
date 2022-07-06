/*Este programa pide al usuario una temperatura,que pedirá hasta que el usuario
introduzca una temperatura válida,luego le pedirá la unidad de dicha temperatura
si es F la convertirá a celsius,si es C la convertirá a Fahrenheit y si no es
ninguno de los 2 dará un error y terminará el programa*/
using System;
class Practica_3_1_2
{
	
	static void Main()
	{
		char unidadgrados;
		float grados=0,grados2;
		bool valido=false;
		
		do
		{
			try
			{
				Console.WriteLine("Digame la temperatura");
				grados = Convert.ToSingle(System.Console.ReadLine());
				valido=true;
			}
		
			catch(FormatException e)
			{
				Console.WriteLine(e.Message);
				
			}
		}	
		while(valido==false);
		try
		{	
			Console.WriteLine("Digame la unidad");
			unidadgrados = Convert.ToChar(System.Console.ReadLine());
			
			if (unidadgrados=='F')
			{
				grados2=(grados-32)*5/9;
				Console.WriteLine("{0} grados Fahrenheit son {1} grados Celsius"
				,grados.ToString("N1"),grados2.ToString("N1"));
			}
			else if (unidadgrados=='C')
			{
				grados2=grados*9/5 +32;
				Console.WriteLine("{0} grados Fahrenheit son {1} grados Celsius"
				,grados.ToString("N1"),grados2.ToString("N1"));
			}
			else
			{
				Console.WriteLine("Unidad no válida");
			}
		}
		catch(FormatException)
		{
			Console.WriteLine("Unidad no válida");
		}
		
		
	}		
	
}
