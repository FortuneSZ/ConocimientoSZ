/* Programa que calcule cuantas cerillas necesitas por cada triangulo
 * (3 cerillas = 1 triangulo) */

class Cerilla
{
    static void Main()
    {
        int triangulo = 0, altura, cerilla;
        do
        {
            Console.WriteLine("Escribe la altura");
            altura = Convert.ToInt32(Console.ReadLine());
            if (altura != 0)
            {
                for (int i = 1; i <= altura; i++)
                {
                    triangulo += i;
                }
                cerilla = 3 * triangulo;
                Console.WriteLine(cerilla);
            }
        }
        while (altura != 0);
    }
}
