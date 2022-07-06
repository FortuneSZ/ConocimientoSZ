/* Este programa solicitará un número de grados celsiu y los convertirá
 * en grados fahrnenheit */
using System;
class Practica_1_1_2
{
	
	static void Main()
	{	
		int celsiu,fahrnenheit;	
		Console.WriteLine("Dime una temperatura en grados centigrados");
		//los grados centígrados tambien son llamados grados celsiu
		celsiu=Convert.ToInt32(System.Console.ReadLine());	
		fahrnenheit=celsiu * 9 / 5 + 32;
			
		Console.WriteLine("{0} grados celsiu"+ 
		",son {1} grados fahrenheit",celsiu,fahrnenheit);
		
	}
}
