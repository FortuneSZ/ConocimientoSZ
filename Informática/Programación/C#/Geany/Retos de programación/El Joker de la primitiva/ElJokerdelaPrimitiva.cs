using System;

class ElJokerdelaPrimitiva
{
    static char[] convertirstring(string numero)
    {
        char[] resultado = new char [numero.Length];
        
        for (int i=0;i<numero.Length;i++)
        {
            resultado [i] = numero[i];
        }
        
        return resultado;
    }
    
    static string convertirarray(char[] array)
    {
        string resultado = "";
        
        foreach (char letra in array)
        {
            resultado = resultado + letra;
        }
        
        return resultado;
    }
    
	static void Main()
	{
        int veces;
        string texto;
        char[] digitos1,digitos2;
        Console.WriteLine("escribe el número de casos");
        veces = Convert.ToInt32(Console.ReadLine());
        
        for (int i=0;i<veces;i++)
        {
            Console.WriteLine("Escribe el número del boleto y separado el número"
            +"ganador");
            texto = Console.ReadLine();
            string[] partes = texto.Split();
            digitos1 = convertirstring(partes[0]);
            digitos2 = convertirstring(partes[1]);
            Array.Sort(digitos1);
            Array.Sort(digitos2);
            
            partes[0] = convertirarray(digitos1);
            partes[1] = convertirarray(digitos2);
            
            if (partes[0] == partes[1])
            {
                Console.WriteLine("gana");
            }
            else
            {
               Console.WriteLine("pierde"); 
            }
        }
        
        
    }
}
