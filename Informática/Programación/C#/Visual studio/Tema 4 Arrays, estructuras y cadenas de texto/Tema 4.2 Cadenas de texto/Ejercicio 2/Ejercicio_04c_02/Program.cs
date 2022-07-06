/*Este programa le pedirá al usuario que introduzca un nombre,y le dirá la
inicial de este*/
class Ejercicio_04c_02
{
    static void Main()
    {
        string nombre;
        Console.WriteLine("escriba su nombre");
        nombre = Console.ReadLine();
        char inicial = nombre[0];
        Console.WriteLine("su inicial es {0}", inicial);

    }

}
