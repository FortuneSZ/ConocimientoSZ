/*Este programa pedira al usuario el precio de lo que quiere comprar y el
dinero que utilizara para comprarlo,y en base a ello le dara su
correspondiente cambio */
class Practica_2_3_2
{
    static void Main()
    {
        int dinero, coste, cambio;
        int bil50 = 0, bil20 = 0, bil10 = 0, bil5 = 0, mon2 = 0, mon1 = 0;

        Console.WriteLine("¿cuanto cuesta lo que va a comprar?");
        coste = Convert.ToInt32(System.Console.ReadLine());

        Console.WriteLine("¿cuanto dinero va a emplear?");
        dinero = Convert.ToInt32(System.Console.ReadLine());
        cambio = dinero - coste;

        if (coste == dinero)
        {
            Console.WriteLine("El importe es exacto");
        }
        else
        {
            Console.WriteLine("total a devolver {0}", cambio);

            while (cambio >= 50)
            {
                bil50++;
                cambio = cambio - 50;
            }

            while (cambio >= 20)
            {
                bil20++;
                cambio = cambio - 20;
            }

            while (cambio >= 10)
            {
                bil10++;
                cambio = cambio - 10;
            }

            while (cambio >= 5)
            {
                bil5++;
                cambio = cambio - 5;
            }

            while (cambio >= 2)
            {
                mon2++;
                cambio = cambio - 2;
            }

            while (cambio >= 1)
            {
                mon1++;
                cambio = cambio - 1;
            }
        }
        if (bil50 != 0)
        {
            Console.WriteLine("{0} de 50", bil50);
        }
        if (bil20 != 0)
        {
            Console.WriteLine("{0} de 20", bil20);
        }
        if (bil10 != 0)
        {
            Console.WriteLine("{0} de 10", bil10);
        }
        if (bil5 != 0)
        {
            Console.WriteLine("{0} de 5", bil5);
        }
        if (mon2 != 0)
        {
            Console.WriteLine("{0} de 2", mon2);
        }
        if (mon1 != 0)
        {
            Console.WriteLine("{0} de 1", mon1);
        }
    }
}
