/*este programa pide al usuario 2 numeros,con los cuales calcula su division
y el resto de la misma */ 
class ejercicio_01c_02
{
	
	static void Main()
	{
			int n1,n2;
			System.Console.WriteLine("escribe el primer numero");
			n1=System.Convert.ToInt32(System.Console.ReadLine());
			
			System.Console.WriteLine("escribe el segundo numero");
			n2=System.Convert.ToInt32(System.Console.ReadLine());
			
			int div=n1/n2,rest=n1%n2;
			System.Console.WriteLine
			("la división de {0} y {1} es {2} y el resto es {3}",n1,n2,div,rest);
		
	}
}
