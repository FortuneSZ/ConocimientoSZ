/* 
 * Programa que le pide al usuario un número de mes y le dice qué mes
 * es, utilizando enums
 */ 
 
using System;

class Ejercicio_03c_08
{
	enum meses {
		ENERO=1, FEBRERO, MARZO, ABRIL,
		MAYO, JUNIO, JULIO, AGOSTO,
		SEPTIEMBRE, OCTUBRE, NOVIEMBRE, DICIEMBRE
	};
	
    static void Main()
    {
		int numero;
		
		Console.WriteLine("Escribe un número de mes:");
		numero = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine((meses)numero);
    }
}
