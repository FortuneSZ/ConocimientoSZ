/*Este programa almacenará en un array el número de días que tiene cada mes
y en base al número que introduzca el usuario(del 1 al 12) le dirá cuantos
días tiene dicho mes,y que mes es*/
using System;

class Ejercicio_04a_02
{
	static void Main()
	{
		int [] dias = new int [12] {31,28,31,30,31,30,31,31,30,31,30,31};
		int mes;	
		
		Console.WriteLine("escriba el numero del mes");
		mes = Convert.ToInt32(Console.ReadLine());
		switch(mes)
		{
			case 1:
			Console.WriteLine("Enero, tiene {0}",dias[0]);
			break;
			case 2:
			Console.WriteLine("Febrero, tiene {0}",dias[1]);
			break;
			case 3:
			Console.WriteLine("Marzo, tiene {0}",dias[2]);
			break;
			case 4:
			Console.WriteLine("Abril, tiene {0}",dias[3]);
			break;
			case 5:
			Console.WriteLine("Mayo, tiene {0}",dias[4]);
			break;
			case 6:
			Console.WriteLine("Junio, tiene {0}",dias[5]);
			break;
			case 7:
			Console.WriteLine("Julio, tiene {0}",dias[6]);
			break;
			case 8:
			Console.WriteLine("Agosto, tiene {0}",dias[7]);
			break;
			case 9:
			Console.WriteLine("Septiembre, tiene {0}",dias[8]);
			break;
			case 10:
			Console.WriteLine("Octubre, tiene {0}",dias[9]);
			break;
			case 11:
			Console.WriteLine("Noviembre, tiene {0}",dias[10]);
			break;
			case 12:
			Console.WriteLine("Diciembre, tiene {0}",dias[11]);
			break;
		}
	}
}
		
