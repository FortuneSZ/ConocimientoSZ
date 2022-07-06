/*
 * Programa que dibuja un trapecio descendente con la anchura, altura
 * y carácter de relleno que diga el usuario
 */

class Repaso1_2
{
    static void Main()
    {
        byte anchura, altura, contadorEspacios;
        int contadorSimbolos;
        char relleno;

        Console.WriteLine("Introduce la anchura:");
        anchura = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Introduce la altura:");
        altura = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Introduce el símbolo de relleno:");
        relleno = Convert.ToChar(Console.ReadLine());

        contadorEspacios = 0;
        contadorSimbolos = anchura + 2 * (altura - 1);

        for (byte i = 1; i <= altura; i++)
        {
            for (byte j = 1; j <= contadorEspacios; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= contadorSimbolos; k++)
            {
                Console.Write(relleno);
            }

            Console.WriteLine();
            contadorEspacios++;
            contadorSimbolos -= 2;
        }

    }
}
