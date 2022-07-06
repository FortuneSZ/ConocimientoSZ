/*Este programa pedirá su edad al usuario hasta que introduzca un valor válido
(entre 0 y 120)*/

class Ejercicio_05b_01
{

    static void Main()
    {
        int edad;

        do
        {
            Console.WriteLine("dime tu edad");
        }
        while (!Int32.TryParse(Console.ReadLine(), out edad) ||
        edad < 0 || edad > 120);

    }

}
