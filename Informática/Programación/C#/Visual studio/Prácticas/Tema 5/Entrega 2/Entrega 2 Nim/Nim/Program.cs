/*Programa para jugar al Nim simplificado contra la máquina con
 * opción a dos dificultades*/

class Nim
{

    static void Main()
    {
        int fichas, dif, turno;
        Random r = new Random();
        turno = r.Next(0, 2);

        fichas = Fichas();
        dif = Dificultad();

        Console.WriteLine("Inciando juego del Nim con {0} fichas, nivel {1}",
            fichas, dif);
        while (fichas > 1)
        {
            if (turno == 0)
            {
                Console.WriteLine("Turno del usuario.");
                TurnoUsuario(ref fichas);
                turno = 1;
            }
            else
            {
                Console.WriteLine("Turno del ordenador.");
                TurnoOrdenador(dif, ref fichas);
                turno = 0;
            }
        }
        if (fichas == 0)
        {
            switch (turno)
            {
                case 0:
                    turno = 1;
                    break;
                case 1:
                    turno = 0;
                    break;
            }
        }

        if (turno == 0)
            Console.WriteLine("Gana el ordenador.");
        else
            Console.WriteLine("Gana el usuario.");

    }

    static int Fichas()
    {
        int a, fichas = 0;
        while (fichas < 10 || fichas > 20)
        {
            Console.Write("Cuántas fichas quieres que haya? (de 10 a 20): ");
            if (Int32.TryParse(Console.ReadLine(), out a))
                fichas = a;
            else
                Console.WriteLine("No es una cantidad válida");
            if (fichas < 10 || fichas > 20)
                Console.WriteLine("Número de fichas incorrecto");

        }
        return fichas;
    }

    static int Dificultad()
    {
        int a, dif = 0;
        while (dif != 1 && dif != 2)
        {
            Console.Write("Escoge la difucltad (1: Fácil. 2: Dificil): ");
            if (Int32.TryParse(Console.ReadLine(), out a))
                dif = a;
            else
                Console.WriteLine("No es una dificultad válida");

        }
        return dif;
    }
    static void TurnoUsuario(ref int fichas)
    {
        int a, retirar = 0;
        int max = fichas < 3 ? fichas : 3;
        while (retirar < 1 || retirar > max)
        {
            Console.Write("Escoge cuantas fichas retirar (de 1 a {0}): ", max);
            if (Int32.TryParse(Console.ReadLine(), out a))
                retirar = a;
            else
                Console.WriteLine("No se puede retirar esa cantidad");
            if (retirar < 1 || retirar > max)
                Console.WriteLine("Número incorrecto");
        }
        fichas -= retirar;
        Console.WriteLine("Quedan {0} fichas.", fichas);
    }
    static void TurnoOrdenador(int dif, ref int fichas)
    {
        int retirar = 0;
        int max = fichas < 3 ? fichas : 3;
        Random r = new Random();
        switch (dif)
        {
            case 1:
                retirar = r.Next(1, max + 1);
                break;

            case 2:
                retirar = (fichas + 3) % 4;
                retirar = retirar == 0 ? 1 : retirar;
                break;
        }
        Console.WriteLine("Fichas retiradas por el ordenador: {0}.", retirar);
        fichas -= retirar;
        Console.WriteLine("Quedan {0} fichas.", fichas);
    }
}
