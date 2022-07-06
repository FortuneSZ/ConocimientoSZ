/*Este programa elimina los espacios innecesarios en el texto introducido
por el usuario*/
class Ejercicio_04c_09
{
    static void Main()
    {
        string texto;
        Console.WriteLine("escriba un texto");
        texto = Console.ReadLine();
        while (texto.Contains("  "))
        {
            texto = texto.Replace("  ", " ");
        }
        Console.WriteLine("texto corregido");
        Console.WriteLine(texto);
    }

}
