/*este programa consiste en introducir un caracter o digito,y en funcion de
lo que sea decir si es un numero,digito u otra cosa*/
using System;
class ejercicio_02a_14
{

	static void Main()
	{
		char letra;

		Console.WriteLine("dime una letra o un dígito");
		letra = Convert.ToChar(System.Console.ReadLine());

		switch (letra)
		{
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case '0':

				Console.WriteLine("es un digito");
				break;
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'G':
			case 'H':
			case 'I':
			case 'J':
			case 'K':
			case 'L':
			case 'M':
			case 'N':
			case 'O':
			case 'P':
			case 'Q':
			case 'R':
			case 'S':
			case 'T':
			case 'U':
			case 'V':
			case 'W':
			case 'X':
			case 'Y':
			case 'Z':
				Console.WriteLine("es una letra mayuscula");
				break;


			default:
				Console.WriteLine("es otra cosa");
				break;
		}

	}
}
