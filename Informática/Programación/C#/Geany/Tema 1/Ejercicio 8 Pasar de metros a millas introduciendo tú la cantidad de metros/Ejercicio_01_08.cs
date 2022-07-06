// este programa pasa de metros a millas y lo muestra en pantalla
class ejercicio_01c_08
{
	
	static void Main()
	{		
			float M=1609;
			
		
		System.Console.WriteLine("escribe el número de metros que quieres convertir");
		float A = System.Convert.ToSingle(System.Console.ReadLine());
		float C=A/M;
		System.Console.WriteLine("{0} convertido a millas son {1} millas",A,C);
		
		
	}
}
