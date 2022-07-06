/*Este programa pide al usuario un texto que consista en números separados por
espacios simples,y posteriormente realizará la suma de dichos números*/
class Ejercicio_04c_011
{
    static void Main()
    {
        string secuencia;
        int total = 0;
        Console.WriteLine("Introduce numeros separados por espacios: ");
        secuencia = Console.ReadLine();
        string[] numero = secuencia.Split(' ');
        for (int i = numero.Length; i > 0; i--)
        {
            total = total + Convert.ToInt32(numero[i - 1]);
        }
        Console.WriteLine("Resultado : {0}", total);
    }
}
