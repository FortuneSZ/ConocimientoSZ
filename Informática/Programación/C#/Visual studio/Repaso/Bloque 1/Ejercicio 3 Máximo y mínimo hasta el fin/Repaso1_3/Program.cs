/*
 * Programa que le pide al usuario números reales y calcula en cada 
 * iteración el máximo y mínimo, hasta que el usuario escribe "fin"
 */

class Repaso1_3
{
    static void Main()
    {
        string texto;
        int contador = 0;
        double numero, minimo = 0, maximo = 0;

        Console.WriteLine("Escribe números, y \"fin\" para terminar");

        do
        {
            texto = Console.ReadLine();
            if (texto != "fin")
            {
                numero = Convert.ToDouble(texto);
                if (numero > maximo || contador == 0)
                {
                    maximo = numero;
                }
                if (numero < minimo || contador == 0)
                {
                    minimo = numero;
                }

                contador++;

                Console.WriteLine("Max = {0}, Min = {1}", maximo, minimo);
            }
        }
        while (texto != "fin");
    }
}

